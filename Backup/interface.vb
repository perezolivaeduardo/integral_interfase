Module sdkinterface
    Public chr13 As String = Microsoft.VisualBasic.Chr(13)
    Function leer_tabla(ByVal cmd As String) As DataTable
        Dim da As New SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.integraConnectionString
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
        da.Fill(tbl)
        leer_tabla = tbl
    End Function
    Public Function bitacora(ByVal linea As String) As Boolean
        Try
            Dim f As New System.IO.StreamWriter("c:\tmp\logfile.txt", True)
            Dim l As String
            l = "Aplicar Venta|" + Now.ToShortDateString + "|" + linea
            f.WriteLine(l)
            f.Close()
            bitacora = True
        Catch ex As Exception
            bitacora = False
        End Try
    End Function 'Bitacora

End Module
