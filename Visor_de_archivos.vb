Public Class Visor_de_archivos
    Dim ds1 As New DataSet("movimientos")
    Dim tblp As DataTable = ds1.Tables.Add("pagos")
    Dim tbld As DataTable = ds1.Tables.Add("pagos_detalle")
    Dim bs As New BindingSource

    Private Sub boton_abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_abrir.Click
        Me.OpenFileDialog1.ShowDialog()
        file.Text = Me.OpenFileDialog1.FileName

        tablas(file.Text)
        cargar(file.Text)
    End Sub

    Public Sub cargar(ByVal file As String)
        ds1.ReadXmlSchema(file)

        'Crea data set y genera relation
        Dim pcol As DataColumn = ds1.Tables("pagos").Columns("id_pago")
        Dim child As DataColumn = ds1.Tables("pagos_detalle").Columns("id_pago")
        Try
            Dim facrelation As DataRelation
            facrelation = New DataRelation("movimientos", pcol, child)
            ds1.Relations.Add(facrelation)

        Catch ex As Exception

        End Try

        dgv.DataSource = ds1
        dgv.DataMember = "pagos"
        bs.DataSource = ds1.Tables("pagos_detalle")
        dgv2.DataSource = bs

        ds1.ReadXml(file)
    End Sub

    Private Sub tablas(ByVal file As String)
        Dim ds As New DataSet
        Dim t As DataTable
        ds.ReadXmlSchema(file)
        Me.ListBox1.Items.Clear()
        For Each t In ds.Tables
            Me.ListBox1.Items.Add(t.TableName)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim s As String = ListBox1.SelectedItem
        dgv.DataMember = s
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
    End Sub

    Private Sub boton_consular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_consular.Click
        My.Forms.consultar_base.Show()
    End Sub
End Class