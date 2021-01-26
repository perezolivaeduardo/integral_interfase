Public Class info_caja
    Dim bs As New BindingSource
    Private Sub info_caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.IntegraDataSet.cajas)

    End Sub

    Private Sub caja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caja.KeyPress
        If e.KeyChar = chr13 Then
            Me.CajasBindingSource.Find("id_caja", caja.Text)
        End If
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged

    End Sub
    Private Sub define_nombre()
        file.Text = "Mov_caja_" + Id_caja.Text + "_" + Format(fecha.Value, "ddMyyyy") + ".xml"
    End Sub

    Private Sub boton_resumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_resumen.Click
        Dim cmd As String
        cmd = "SELECT Documentos.fechafactura, tbl_Tipodoc.td, tbl_Tipodoc.Descripciom, Documentos.serie, MIN(Documentos.Folio) AS ini, MAX(Documentos.Folio) AS Fin, Documentos.ncaja " _
        & " FROM Documentos INNER JOIN tbl_Tipodoc ON Documentos.td = tbl_Tipodoc.td " _
        & " GROUP BY Documentos.ncaja, Documentos.fechafactura, tbl_Tipodoc.td, tbl_Tipodoc.Descripciom, Documentos.serie " _
        & " HAVING (Documentos.fechafactura = CONVERT(DATETIME, '" + Format(fecha.Value, "yyyy-M-dd") + "', 102)) "
        Dim tbl As DataTable = leer_tabla(cmd)
        bs.DataSource = tbl
        dgv.DataSource = tbl
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

   
    Private Sub boton_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_todos.Click
        Dim cmd As String
        cmd = "SELECT Documentos.fechafactura, tbl_Tipodoc.td, tbl_Tipodoc.Descripciom, Documentos.serie, MIN(Documentos.Folio) AS ini, MAX(Documentos.Folio) AS Fin, Documentos.ncaja " _
        & " FROM Documentos INNER JOIN tbl_Tipodoc ON Documentos.td = tbl_Tipodoc.td " _
        & " GROUP BY Documentos.ncaja, Documentos.fechafactura, tbl_Tipodoc.td, tbl_Tipodoc.Descripciom, Documentos.serie "
        Dim tbl As DataTable = leer_tabla(cmd)
        bs.DataSource = tbl
        dgv.DataSource = tbl
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub SplitContainer2_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub aplicar_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aplicar_filtro.Click
        bs.Filter = filtrotxt.Text
    End Sub
End Class