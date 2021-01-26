Public Class ftp

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_conectar.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim ftp As New Utilities.FTP.FTPclient(My.Settings.ftp_server, My.Settings.ftp_user, My.Settings.ftp_pw)
        'upload a file
        Dim lista As List(Of String)
        lista = ftp.ListDirectory(carpeta.Text)
        For j As Integer = 0 To lista.Count - 1
            Dim s As String
            s = lista.Item(j)
            If Mid(s, 1, 1) <> "." Then ListBox1.Items.Add(s)
        Next
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ftp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.paths' Puede moverla o quitarla según sea necesario.
        Me.PathsTableAdapter.Fill(Me.IntegraDataSet.paths)

    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Private Sub PathsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PathsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PathsBindingSource.EndEdit()
        Me.PathsTableAdapter.Update(Me.IntegraDataSet.paths)

    End Sub
End Class