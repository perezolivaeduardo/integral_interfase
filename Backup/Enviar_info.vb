Public Class Enviar_info
    Dim tablas(0 To 2, 0 To 15)
    Dim nt As Integer = 7
    Dim fileorigen As String
    Dim fileftp As String
    Dim tablas_sys As New DataTable
    Dim usbfolder As String
    Dim usbfile As String

    Private Sub Enviar_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.FillByexternas(Me.IntegraDataSet.cajas)
        tablas(0, 0) = "Agentes" : tablas(1, 0) = "Agentes"
        tablas(0, 1) = "Departamentos" : tablas(1, 1) = "Departamentos"
        tablas(0, 2) = "Directorio" : tablas(1, 2) = "Directorio"
        tablas(0, 3) = "Grupos" : tablas(1, 3) = "Grupos"
        tablas(0, 4) = "listas" : tablas(1, 4) = "Listas"
        tablas(0, 5) = "productos" : tablas(1, 5) = "productos"
        tablas(0, 6) = "usuarios" : tablas(1, 6) = "usuarios"
        tablas(0, 7) = "tbl_almacenes" : tablas(1, 7) = "tbl_almacenes"
        tablas(0, 8) = "fei_clientes" : tablas(1, 8) = "fei_clientes"
        tablas(0, 9) = "Paquetes" : tablas(1, 9) = "paquetes"
        tablas(0, 10) = "Paquetes_detalle" : tablas(1, 10) = "paquetes_detalle"
        tablas(0, 11) = "productos_stoks" : tablas(1, 11) = "productos_stoks"
        nt = 11
        Dim j As Integer
        For j = 0 To nt
            lista.Items.Add(tablas(1, j))
        Next
        Dim cmd As String = "select * from sys_envio_de_tablas"
        tablas_sys = leer_tabla(cmd)
        Me.lista_sys.DataSource = tablas_sys
        Me.lista_sys.DisplayMember = "tabla"
    End Sub

    Private Sub preparar_tablas()
        'Esta opcion manda las tablas seleccionadas, se puede mandar las veces que quiera
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim adap As New integraDataSetTableAdapters.pathsTableAdapter
        Dim path As String = Trim(adap.leer_path(5))
        pathtxt.Text = path
        Dim filedestino As String = path.Trim + "\tablas.xml"
        usbfile = "\tablas.xml"
        Dim ds As New DataSet
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        For j As Integer = 0 To lista.CheckedItems.Count - 1
            Dim tabla As String = lista.CheckedItems(j)
            Dim tbl As DataTable = ds.Tables.Add(tabla)
            pathtxt.Text = "Exportando " + tabla
            Dim sql As String = "SELECT  *  FROM " + tabla
            AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
            AD.Fill(tbl)
        Next
        ds.WriteXml(filedestino)
        pathtxt.Text = filedestino
        Windows.Forms.Cursor.Current = Cursors.Default
        fileorigen = filedestino
        fileftp = My.Settings.carpeta_tiendas + "\tablas.xml"
    End Sub 'Preparar Tabla   Tablas.xml

    Private Sub preparar_precios()
        ' manda la tabla de Unidades_productos. Precios.
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim adap As New integraDataSetTableAdapters.pathsTableAdapter
        Dim path As String
        path = adap.leer_path(5).ToString
        path = path.Trim
        Dim file As String = "Precios_" + (Me.NombreComboBox.Text).Trim + ".xml"
        usbfile = "\" + file
        fileftp = My.Settings.carpeta_tiendas + file
        Dim filedestino As String = Trim(path) + file
        Dim ds As New DataSet
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        Dim tabla As String = "Unidades_productos"
        Dim tbl As DataTable = ds.Tables.Add(tabla)
        Dim sql As String = "SELECT  *  FROM " + tabla
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl) : ds.WriteXml(filedestino)
        pathtxt.Text = filedestino
        fileorigen = filedestino
    End Sub 'preparar lista de precios Precios_NOMBRE-TIENDA.xml

    Private Sub preparar_tablas_sistema()
        'Prepar las tablas del sistema, estas se subsistuyen
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim adap As New integraDataSetTableAdapters.pathsTableAdapter
        Dim path As String = Trim(adap.leer_path(5))
        pathtxt.Text = path
        Dim filedestino As String = path.Trim + "\tablas_sys.xml"
        usbfile = "\tablas_sys.xml"

        Dim ds As New DataSet
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter
        For j As Integer = 0 To tablas_sys.Rows.Count - 1
            Dim tabla As String = tablas_sys.Rows(j).Item(0).ToString.Trim
            Dim tbl As DataTable = ds.Tables.Add(tabla)
            pathtxt.Text = "Exportando " + tabla
            Dim sql As String = "SELECT * FROM " + tabla
            AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
            AD.Fill(tbl)
        Next
        ds.WriteXml(filedestino)
        pathtxt.Text = filedestino
        Windows.Forms.Cursor.Current = Cursors.Default
        fileorigen = filedestino
        fileftp = My.Settings.carpeta_tiendas + "\tablas_sys.xml"
    End Sub 'Prepara tblas del sistema

    Private Sub boton_USB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_USB.Click
        Me.FolderBrowserDialog.ShowDialog()
        usbfolder = Me.FolderBrowserDialog.SelectedPath
        If Me.TabControl1.SelectedIndex = 0 Then
            preparar_tablas()
            FileCopy(fileorigen, usbfolder + "\" + usbfile)
            Windows.Forms.Cursor.Current = Cursors.Default
            MsgBox("Archivo Copiado")
        End If
        If Me.TabControl1.SelectedIndex = 1 Then
            preparar_precios()
            FileCopy(fileorigen, usbfolder + "\" + usbfile)
            Windows.Forms.Cursor.Current = Cursors.Default
            MsgBox("Archivo Copiado")
        End If
        If Me.TabControl1.SelectedIndex = 2 Then
            preparar_tablas_sistema()
            FileCopy(fileorigen, usbfolder + "\" + usbfile)
            Windows.Forms.Cursor.Current = Cursors.Default
            MsgBox("Archivo Copiado")
        End If
    End Sub

    Private Sub boton_ftp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ftp.Click
        If Me.TabControl1.SelectedIndex = 0 Then
            preparar_tablas()
            ftp(fileorigen, fileftp)
            Windows.Forms.Cursor.Current = Cursors.Default
            MsgBox("Archivo Generado")
        End If
        If Me.TabControl1.SelectedIndex = 1 Then
            preparar_precios()
            ftp(fileorigen, fileftp)
            Windows.Forms.Cursor.Current = Cursors.Default
            MsgBox("Archivo Generado")
        End If
        If Me.TabControl1.SelectedIndex = 2 Then
            preparar_tablas_sistema()
            ftp(fileorigen, fileftp)
            Windows.Forms.Cursor.Current = Cursors.Default
            MsgBox("Archivo Enviado")
        End If
    End Sub

    Private Sub ftp(ByVal fileorigen As String, ByVal fileftp As String)
        Dim ftp As New Utilities.FTP.FTPclient(My.Settings.ftp_server, My.Settings.ftp_user, My.Settings.ftp_pw)
        Me.Refresh()
        ftp.Upload(fileorigen, fileftp)
    End Sub

    Private Sub boton_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_end.Click
        Me.Close()
    End Sub
End Class
