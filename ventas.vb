Public Class ventas
    Dim path_descarga, path_descarga_original As String

    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CajasTableAdapter.FillByexternas(Me.IntegraDataSet.cajas)
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim sql As String = "Select * from paths where id = 3"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl)
        path_descarga = Trim(tbl.Rows(0).Item(2))
        path_descarga_original = path_descarga
        Me.lbldestino.Text = path_descarga
        carpetatxt.Text = path_descarga
        boton_aplicar.Enabled = My.Computer.FileSystem.FileExists(path_descarga + filetxt.Text)
        Me.Text = "Aplicar Ventas V.3.0.1"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub define_nombre()
        filetxt.Text = "Mov_caja_" + Id_caja.Text + "_" + Format(fecha.Value, "ddMyyyy") + ".xml"
    End Sub

    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        If fecha.Value.Date < Now.Date.AddDays(-2) Then MsgBox("Va a aplicar ventas de 2 Dias atras, verifique bien la fecha")
        define_nombre()
        validar_existencia()
    End Sub

    Private Sub Id_caja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_caja.TextChanged
        define_nombre()
    End Sub

    Private Sub descargar(ByVal file As String)
        Dim filedestino As String = path_descarga + file
        Dim fileorigen As String = "http://" + My.Settings.ftp_server + My.Settings.ftp_cortes + file
        status.Text = "Descargando " + file
        Me.Refresh()
        Try
            My.Computer.Network.DownloadFile(fileorigen, filedestino, "", "", True, 100, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        status.Text = "" : Me.Refresh()
    End Sub

    Private Sub filetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filetxt.TextChanged
        validar_Existencia()
    End Sub
    Private Sub validar_existencia()

        boton_aplicar.Enabled = My.Computer.FileSystem.FileExists(path_descarga + "\" + filetxt.Text)
        Dim nc As Integer = Me.Id_caja.Text
        Dim f As Date = fecha.Value
        Dim x As Boolean = validar(nc, f)
        If x = True Then Me.boton_borrar.Enabled = True
    End Sub

    Private Sub boton_descargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_descargar.Click
        descargar(filetxt.Text)
        validar_existencia()
    End Sub

    Private Sub boton_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_end.Click
        Me.Close()
    End Sub

    Private Sub boton_aplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_aplicar.Click
        Dim nc As Integer = Me.Id_caja.Text
        Dim f As Date = fecha.Value
        Dim x As Boolean = validar(nc, f)
        If x = True Then
            Dim y As MsgBoxResult
            y = MsgBox("Este dia ya fue aplicado,Quiere Borrarlo y aplicarlo de nuevo?", MsgBoxStyle.YesNo, "Borra Mominentos ")
            If y = MsgBoxResult.No Then Exit Sub
            borrar_movimientos(f, nc)
            cargar(path_descarga + filetxt.Text)
        Else
            cargar(path_descarga + filetxt.Text)
        End If
        If path_descarga_original <> path_descarga Then
            FileCopy(path_descarga + filetxt.Text, path_descarga_original + filetxt.Text)
        End If
    End Sub

    Private Function validar(ByVal caja As Integer, ByVal fe As Date) As Boolean
        Dim adap As New integraDataSetTableAdapters.DocumentosTableAdapter
        Dim x As Integer
        Try
            x = adap.ndocumentos(fecha.Value.Date, caja)
            If x > 0 Then validar = True
        Catch ex As Exception
            MsgBox(ex.Message)
            validar = False
        End Try
    End Function

    Private Sub cargar(ByVal file As String)
        Dim j As Integer, bs As New BindingSource
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim nc As Integer = Me.Id_caja.Text
        Dim ds1 As New DataSet
        'lee la tabla
        ds1.Clear()
        ds1.ReadXmlSchema(file)
        ds1.ReadXml(file)
        bs.DataSource = ds1.Tables("pagos_detalle")
        dgv.DataSource = bs

        For j = 0 To ds1.Tables("documentos").Rows.Count - 1
            ds1.Tables("documentos").Rows(j).Item("fechasurtido") = CDate(fecha.Value.ToShortDateString)
        Next

        '************* importa documentos
        Dim adadaplo As New integraDataSetTableAdapters.log_cajasTableAdapter
        Dim dbdslo As New integraDataSet.log_cajasDataTable
        Try
            For j = 0 To ds1.Tables("log_cajas").Rows.Count - 1
                dbdslo.ImportRow(ds1.Tables("log_cajas").Rows(j))
            Next
        Catch ex As Exception

        End Try

        Try
            adadaplo.Update(dbdslo)
        Catch ex As Exception
            bitacora("Aplicar_ventas " + ex.Message)
        End Try

        '************* importa documentos
        Dim adaptador As New integraDataSetTableAdapters.DocumentosTableAdapter
        Dim dbds As New integraDataSet.DocumentosDataTable
        dbds.Clear()
        For j = 0 To ds1.Tables("documentos").Rows.Count - 1
            dbds.ImportRow(ds1.Tables("documentos").Rows(j))
        Next
        Try
            adaptador.Update(dbds)
        Catch ex As Exception
            bitacora("Aplicar_ventas " + ex.Message)
            MsgBox(ex.Message + " APLIQUE DE NUEVO")
            '  Exit Sub
        End Try


        '************* importar movimientos
        Dim adapmov As New integraDataSetTableAdapters.movimientosTableAdapter
        Dim movds As New integraDataSet.movimientosDataTable
        For j = 0 To ds1.Tables("movimientos").Rows.Count - 1
            movds.ImportRow(ds1.Tables("movimientos").Rows(j))
        Next
        Try
            adapmov.Update(movds)
        Catch ex As Exception
            bitacora("Actaliza Ventas" + ex.Message)
            MsgBox(ex.Message + " APLIQUE DE NUEVO")
            ' Exit Sub
        End Try


        '************* importar cfd
        Dim adapcdf As New integraDataSetTableAdapters.fei_cfdTableAdapter
        Dim cdfds As New integraDataSet.fei_cfdDataTable
        For j = 0 To ds1.Tables("fei_cfd").Rows.Count - 1
            cdfds.ImportRow(ds1.Tables("fei_cfd").Rows(j))
        Next
        Try
            adapcdf.Update(cdfds)
        Catch ex As Exception
            bitacora("Actaliza Ventas (cfd)" + ex.Message)
            ' MsgBox(ex.Message + " APLIQUE DE NUEVO")
            ' Exit Sub
        End Try

        '************* importar pagos
        Dim adapago As New integraDataSetTableAdapters.PagosTableAdapter
        Dim pagods As New integraDataSet.PagosDataTable
        Dim adapd As New integraDataSetTableAdapters.pagos_detalleTableAdapter
        ' Dim detds As New integraDataSet.pagos_detalleDataTable

        For j = 0 To ds1.Tables("pagos").Rows.Count - 1
            Dim dr1 As DataRow = ds1.Tables("pagos_detalle").NewRow
            Dim id, nid As Integer
            Dim pdr As DataRow

            With ds1.Tables("pagos").Rows(j)
                pdr = ds1.Tables("pagos").Rows(j)
                Dim idpago As Integer = adapago.id(nc)
                adapago.Insert(idpago, CInt(nc), CInt(pdr("id_user")), CInt(pdr("folio")), CInt(pdr("agente")), CDate(fecha.Value.ToShortDateString), CDate(pdr(5)), pdr("aplicado"), CInt(pdr("id_directorio")), CInt(pdr("tipo")), CInt(pdr("id_fp")), pdr("banco"), pdr("referencia"), CDbl(pdr("importe")))
                nid = idpago
                '***************Filtra detalle de pagos por cada pago y lo inserta
                id = .Item(0)
                Dim f As String = "id_pago =" + id.ToString
                bs.Filter = f
                For y As Integer = 0 To dgv.Rows.Count - 1
                    With dgv.Rows(y)
                        adapd.Insert(nid, CInt(.Cells(1).Value), CULng(.Cells(2).Value), .Cells(3).Value, CDbl(.Cells(4).Value), pdr(1))
                    End With
                Next y

            End With
        Next
        '************* importar tmp_productos (productos dados de alta en la tienda)
        Try
            If ds1.Tables("tmp_productos").Rows.Count > 0 Then
                Dim adaprod As New integraDataSetTableAdapters.tmp_productosTableAdapter
                For j = 0 To ds1.Tables("tmp_productos").Rows.Count - 1
                    Dim dr As DataRow
                    dr = ds1.Tables("tmp_productos").Rows(j)
                    With dr
                        Try
                            adaprod.Insert(.Item(0), Val(.Item(1)), .Item(2), Val(.Item(3)), Val(.Item(4)))
                        Catch ex As Exception

                        End Try
                    End With
                Next
            End If
        Catch ex As Exception

        End Try

        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'Cargar movimientos a la base de datos

    Private Sub borrar_movimientos(ByVal fecha As Date, ByVal cj As Integer)
        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.integraConnectionString)
                conection.Open()
                Dim cmd As String
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                cmd = "delete from log_cajas "
                cmd += " WHERE  fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy-M-dd") + "', 102) AND  id_caja=" + cj.ToString + ""
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.DeleteCommand = Command
                AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("No se pudo borra los movimientos")
            MsgBox(ex.Message)
        End Try

        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.integraConnectionString)
                conection.Open()
                Dim cmd As String
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                cmd = "delete from documentos "
                cmd += " WHERE  td > 1 AND "
                cmd = cmd + " fregistro >= CONVERT(DATETIME, '" + Format(fecha, "yyyy-M-dd") + " 00:00:00', 102) and "
                cmd = cmd + "fregistro < =CONVERT(DATETIME, '" + Format(fecha, "yyyy-M-dd") + " 23:59:00', 102) "
                cmd = cmd + " AND  ncaja =" + cj.ToString + ""
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.DeleteCommand = Command
                AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
                MsgBox("Documentos Borrados")
            End Using
        Catch ex As Exception
            MsgBox("No se pudo borra los movimientos")
            MsgBox(ex.Message)
        End Try

        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.integraConnectionString)
                conection.Open()
                Dim cmd As String
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                cmd = "delete from fei_cfd "
                cmd += " WHERE  serie = [serie] AND "
                cmd = cmd + " fecha >= CONVERT(DATETIME, '" + Format(fecha, "yyyy-M-dd") + " 00:00:00', 102) and "
                cmd = cmd + "fecha < =CONVERT(DATETIME, '" + Format(fecha, "yyyy-M-dd") + " 23:59:00', 102) "
                cmd = cmd.Replace("[serie]", SerieTextBox.Text)


                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.DeleteCommand = Command
                AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
                MsgBox("Documentos Borrados")
            End Using
        Catch ex As Exception
            MsgBox("No se pudo borra los movimientos")
            MsgBox(ex.Message)
        End Try



        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.integraConnectionString)
                conection.Open()
                Dim cmd As String
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                cmd = "delete from Pagos "
                cmd += " WHERE  fecha = CONVERT(DATETIME, '" + Format(fecha, "yyyy-M-dd") + "', 102) AND  caja =" + cj.ToString + ""
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.DeleteCommand = Command
                AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
                MsgBox("Pagos Borrados")
            End Using
        Catch ex As Exception
            MsgBox("No se pude borra los pagos")
            MsgBox(ex.Message)

        End Try
    End Sub ' Borra los movimientos del dia de en la base de datos

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nc As Integer = Me.Id_caja.Text
        Dim f As Date = fecha.Value
        Dim x As Boolean = validar(nc, f)
        If x = True Then MsgBox("Si existem Movimientos!!")
    End Sub

    Private Sub boton_revisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_revisar.Click
        My.Forms.info_caja.Show()
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        validar_existencia()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Folder.ShowDialog()
        carpetatxt.Text = Folder.SelectedPath + "\"
        path_descarga = Folder.SelectedPath + "\"
        Me.lbldestino.Text = path_descarga
        boton_aplicar.Enabled = My.Computer.FileSystem.FileExists(path_descarga + "\" + filetxt.Text)
        If path_descarga_original <> path_descarga Then
            Me.boton_copiar.Enabled = True
        End If

    End Sub

   
    Private Sub boton_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_borrar.Click
        Dim nc As Integer = Me.Id_caja.Text
        Dim f As Date = fecha.Value
        Dim y As MsgBoxResult
        y = MsgBox("Este dia ya fue aplicado,Quiere Borrarlo ?", MsgBoxStyle.YesNo, "Borra Mominentos ")
        If y = MsgBoxResult.No Then Exit Sub
        borrar_movimientos(f, nc)
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_copiar.Click
        MsgBox(filetxt.Text)
        FileCopy(path_descarga + filetxt.Text, path_descarga_original + filetxt.Text)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim filename As New OpenFileDialog
        filename.Filter = "CFD|cfd*.xml"
        filename.CheckFileExists = True
        filename.ShowDialog()
        Dim file As String = filename.FileName
        cargar_cfd(file)
    End Sub

    Private Sub cargar_cfd(ByVal file As String)
        Dim j As Integer, bs As New BindingSource
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim nc As Integer = Me.Id_caja.Text
        Dim ds1 As New DataSet
        'lee la tabla
        ds1.Clear()
        ds1.ReadXmlSchema(file)
        ds1.ReadXml(file)

        Dim serie As String = ds1.Tables(0).Rows(0).Item(0)


       

        '************* importa documentos
        Dim adaptador As New integraDataSetTableAdapters.fei_cfdTableAdapter
        Dim dbds As New integraDataSet.fei_cfdDataTable

        adaptador.Borrar_serie(serie)
        dbds.Clear()
        For j = 0 To ds1.Tables("fei_cfd").Rows.Count - 1
            dbds.ImportRow(ds1.Tables("fei_cfd").Rows(j))
        Next

        Try
            adaptador.Update(dbds)
        Catch ex As Exception
            bitacora("Cargar CFD " + ex.Message)
            MsgBox(ex.Message + " cargar de nuevo")
            '  Exit Sub
        End Try



        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub 'Cargar movimientos a la base de datos

End Class