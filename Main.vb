Public Class main

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        My.Forms.ventas.Show()
    End Sub

    Private Sub boton_pedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_pedidos.Click
        My.Forms.pedidos.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.ftp.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        My.Forms.Visor_de_archivos.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        My.Forms.Enviar_info.Show()
    End Sub

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblver.Text = "Ver. " + My.Application.Info.Version.ToString
        'Carga INI
        '==============================================================================================
        Dim f As Integer = FreeFile() : FileOpen(FreeFile, "c:\tmp\caja.ini", OpenMode.Input)
        Dim x As String, sql As String
        Try
            With My.Settings
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                .sqlserver = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
                x = LineInput(f)
            End With
            FileClose(f)
        Catch ex As Exception
            FileClose(f)
        End Try


    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(My.Settings.integraConnectionString)
    End Sub
End Class
