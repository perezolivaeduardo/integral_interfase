Public Class pedidos

    Private Sub boton_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_Export.Click
        icliente.Visible = False
        ifactura.Visible = False
        iproducto.Visible = False
        igrupo.Visible = False
        ilista.Visible = False
        iexistencia.Visible = False
        Me.Refresh()
        Me.FolderBrowserDialog.ShowDialog()
        path.Text = Me.FolderBrowserDialog.SelectedPath

        If chclientes.Checked = True Then clientes()
        If chfacturas.Checked = True Then facturas()
        If chproductos.Checked = True Then productos()
        If chgrupos.Checked = True Then grupos()
        If chlista.Checked = True Then lista()
        If chexistencia.Checked = True Then existencia()
    End Sub

    Private Sub productos()
        Dim filedestino As String = path.Text + "\catalogo.xml"
        Dim ds As New DataSet
        Dim tbl As DataTable = ds.Tables.Add("tabla")

        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter

        Dim sql As String = "SELECT dbo.Unidades_productos.id_producto, dbo.Unidades_productos.id_unidad, dbo.Unidades_productos.Codigo, dbo.Unidades_productos.Unidad, " _
        & "dbo.Unidades_productos.factor, dbo.Unidades_productos.unidades, dbo.Unidades_productos.costo, dbo.Unidades_productos.venta, dbo.productos.Descripcion, " _
        & " dbo.productos.peso, dbo.productos.iva, dbo.productos.precio_unico,dbo.productos.id_Grupo,dbo.productos.id_depto as depto FROM dbo.productos INNER JOIN" _
        & " dbo.Unidades_productos ON dbo.productos.id_Producto = dbo.Unidades_productos.id_producto"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl) : iproducto.Visible = True : Me.Refresh()
        ds.WriteXml(filedestino)

        chproductos.Checked = True
        chproductos.Refresh()
        Me.Refresh()

    End Sub 'Exporta Productos

    Private Sub existencia()
        Dim filedestino As String = path.Text + "\existencia.xml"
        Dim ds As New DataSet
        Dim tbl As DataTable = ds.Tables.Add("tabla")

        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter

        Dim sql As String = "SELECT  *  FROM sql_existencias"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl) : iexistencia.Visible = True : Me.Refresh()
        ds.WriteXml(filedestino)
    End Sub

    Public Sub grupos()
        Dim filedestino As String = path.Text + "\Grupos.xml"
        Dim ds As New DataSet
        Dim tbl As DataTable = ds.Tables.Add("tabla")
        
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter

        Dim sql As String = "SELECT  *  FROM Grupos"
        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl) : igrupo.Visible = True : Me.Refresh()
        ds.WriteXml(filedestino)

    End Sub ' Exportar Grupos

    Private Sub clientes()
        Dim filedestino As String = path.Text + "\clientes_" + Me.NombreComboBox.SelectedValue.ToString + ".xml"
        Dim ds As New DataSet
        Dim tbl As DataTable = ds.Tables.Add("tabla")
        Dim sql As String = "SELECT dbo.Directorio.*, dbo.Listas.Factor as factor FROM dbo.Directorio INNER JOIN " _
        & " dbo.Listas ON dbo.Directorio.Ruta = dbo.Listas.id WHERE dbo.Directorio.id_agente = " + Me.NombreComboBox.SelectedValue.ToString
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter

        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl) : icliente.Visible = True
        ds.WriteXml(filedestino)

    End Sub 'Exportar clientes

    Private Sub facturas()
        Dim filedestino As String = path.Text + "\cxc_" + Me.NombreComboBox.SelectedValue.ToString + ".xml"
        Dim ds As New DataSet
        Dim tbl As DataTable = ds.Tables.Add("tabla")
        Dim sql As String = "SELECT * FROM dbo.interface_facturas WHERE dbo.Interface_facturas.id_agente = " + Me.NombreComboBox.SelectedValue.ToString
        Dim cs As String = My.Settings.integraConnectionString
        Dim AD As New Data.SqlClient.SqlDataAdapter

        AD = New Data.SqlClient.SqlDataAdapter(sql, cs)
        AD.Fill(tbl) : ifactura.Visible = True
        ds.WriteXml(filedestino)
    End Sub 'Exportar Facturas
  
    Private Sub pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'IntegraDataSet.Agentes' Puede moverla o quitarla según sea necesario.
        Me.AgentesTableAdapter.FillBylaptop(Me.IntegraDataSet.Agentes)
        Dim adap As New integraDataSetTableAdapters.pathsTableAdapter
        path.Text = adap.leer_path(1)
    End Sub

    Private Sub lista()
       
    End Sub 'Exporta Precios


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        subir_info()
    End Sub

    Private Sub ftp(ByVal fileorigen As String, ByVal fileftp As String)
        Dim ftp As New Utilities.FTP.FTPclient(My.Settings.ftp_server, My.Settings.ftp_user, My.Settings.ftp_pw)
        Me.Refresh()
        ftp.Upload(fileorigen, fileftp)
    End Sub

    Private Sub subir_info()
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim file1 As String = path.Text + "\catalogo.xml"
        Dim file2 As String = path.Text + "\existencia.xml"
        Dim file3 As String = path.Text + "\Grupos.xml"
        Dim file4 As String = path.Text + "\clientes_" + Me.NombreComboBox.SelectedValue.ToString + ".xml"
        Dim file5 As String = path.Text + "\cxc_" + Me.NombreComboBox.SelectedValue.ToString + ".xml"

        Dim adap As New integraDataSetTableAdapters.pathsTableAdapter
        Dim pathweb As String = adap.leer_path(10)
        pathweb = pathweb.Trim()
        icliente.Visible = False
        ifactura.Visible = False
        iproducto.Visible = False
        igrupo.Visible = False
        ilista.Visible = False
        iexistencia.Visible = False

        Dim ftpfile1 As String = pathweb + "catalogo.xml"
        Dim ftpfile2 As String = pathweb + "existencia.xml"
        Dim ftpfile3 As String = pathweb + "Grupos.xml"
        Dim ftpfile4 As String = pathweb + "clientes_" + Me.NombreComboBox.SelectedValue.ToString + ".xml"
        Dim ftpfile5 As String = pathweb + "cxc_" + Me.NombreComboBox.SelectedValue.ToString + ".xml"

        ftp(file1, ftpfile1) : iproducto.Visible = True
        ftp(file2, ftpfile2) : iexistencia.Visible = True
        ftp(file3, ftpfile3) : igrupo.Visible = True
        ftp(file4, ftpfile4) : icliente.Visible = True
        ftp(file5, ftpfile5) : ifactura.Visible = True
        Windows.Forms.Cursor.Current = Cursors.WaitCursor

    End Sub
End Class