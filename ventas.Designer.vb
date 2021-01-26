<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_descargar = New System.Windows.Forms.ToolStripButton
        Me.boton_aplicar = New System.Windows.Forms.ToolStripButton
        Me.boton_setup = New System.Windows.Forms.ToolStripButton
        Me.boton_end = New System.Windows.Forms.ToolStripButton
        Me.boton_copiar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.boton_salir = New System.Windows.Forms.Button
        Me.IntegraDataSet = New admintegral_interface.integraDataSet
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasTableAdapter = New admintegral_interface.integraDataSetTableAdapters.cajasTableAdapter
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.filetxt = New System.Windows.Forms.TextBox
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Id_caja = New System.Windows.Forms.TextBox
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.status = New System.Windows.Forms.ToolStripLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.boton_borrar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.carpetatxt = New System.Windows.Forms.TextBox
        Me.boton_revisar = New System.Windows.Forms.Button
        Me.lbldestino = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Folder = New System.Windows.Forms.FolderBrowserDialog
        Me.SerieTextBox = New System.Windows.Forms.TextBox
        NombreLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        SerieLabel = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(110, 36)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(74, 18)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Sucursal :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(111, 148)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(65, 18)
        Label1.TabIndex = 9
        Label1.Text = "Archvio :"
        AddHandler Label1.Click, AddressOf Me.Label1_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(119, 77)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 18)
        Label2.TabIndex = 11
        Label2.Text = "Fecha :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(108, 108)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(68, 18)
        Label3.TabIndex = 16
        Label3.Text = "Carpeta :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_descargar, Me.boton_aplicar, Me.boton_setup, Me.boton_end, Me.boton_copiar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 257)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(650, 71)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_descargar
        '
        Me.boton_descargar.Image = Global.admintegral_interface.My.Resources.Resources.Download_2
        Me.boton_descargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_descargar.Name = "boton_descargar"
        Me.boton_descargar.Size = New System.Drawing.Size(171, 68)
        Me.boton_descargar.Text = "Descargar Archivo"
        '
        'boton_aplicar
        '
        Me.boton_aplicar.Enabled = False
        Me.boton_aplicar.Image = Global.admintegral_interface.My.Resources.Resources.Desktop
        Me.boton_aplicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_aplicar.Name = "boton_aplicar"
        Me.boton_aplicar.Size = New System.Drawing.Size(154, 68)
        Me.boton_aplicar.Text = "Aplicar archivo"
        '
        'boton_setup
        '
        Me.boton_setup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_setup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_setup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_setup.Name = "boton_setup"
        Me.boton_setup.Size = New System.Drawing.Size(23, 68)
        Me.boton_setup.Text = "Confiuracion"
        '
        'boton_end
        '
        Me.boton_end.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_end.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_end.Image = Global.admintegral_interface.My.Resources.Resources.Log_Off
        Me.boton_end.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_end.Name = "boton_end"
        Me.boton_end.Size = New System.Drawing.Size(68, 68)
        Me.boton_end.Text = "ToolStripButton1"
        '
        'boton_copiar
        '
        Me.boton_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.boton_copiar.Enabled = False
        Me.boton_copiar.Image = Global.admintegral_interface.My.Resources.Resources.Save_Copy
        Me.boton_copiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_copiar.Name = "boton_copiar"
        Me.boton_copiar.Size = New System.Drawing.Size(68, 68)
        Me.boton_copiar.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.admintegral_interface.My.Resources.Resources.logoSAT
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(126, 68)
        Me.ToolStripButton1.Text = "Bajar CFD"
        '
        'boton_salir
        '
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(312, 195)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(75, 23)
        Me.boton_salir.TabIndex = 5
        Me.boton_salir.Text = "Button1"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.IntegraDataSet
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.CajasBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(186, 35)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(234, 26)
        Me.NombreComboBox.TabIndex = 7
        Me.NombreComboBox.ValueMember = "id_caja"
        '
        'filetxt
        '
        Me.filetxt.Enabled = False
        Me.filetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filetxt.Location = New System.Drawing.Point(186, 147)
        Me.filetxt.Name = "filetxt"
        Me.filetxt.Size = New System.Drawing.Size(234, 24)
        Me.filetxt.TabIndex = 8
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(186, 72)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(110, 24)
        Me.fecha.TabIndex = 10
        '
        'Id_caja
        '
        Me.Id_caja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "id_caja", True))
        Me.Id_caja.Enabled = False
        Me.Id_caja.Location = New System.Drawing.Point(235, 39)
        Me.Id_caja.Name = "Id_caja"
        Me.Id_caja.Size = New System.Drawing.Size(10, 20)
        Me.Id_caja.TabIndex = 12
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 232)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(650, 25)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(39, 22)
        Me.status.Text = "Status"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(SerieLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SerieTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_borrar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.carpetatxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_revisar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldestino)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.filetxt)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_caja)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Label2)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 232)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 14
        '
        'boton_borrar
        '
        Me.boton_borrar.Location = New System.Drawing.Point(307, 72)
        Me.boton_borrar.Name = "boton_borrar"
        Me.boton_borrar.Size = New System.Drawing.Size(87, 23)
        Me.boton_borrar.TabIndex = 18
        Me.boton_borrar.Text = "Borrar Venta"
        Me.boton_borrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(421, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'carpetatxt
        '
        Me.carpetatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carpetatxt.Location = New System.Drawing.Point(186, 102)
        Me.carpetatxt.Name = "carpetatxt"
        Me.carpetatxt.ReadOnly = True
        Me.carpetatxt.Size = New System.Drawing.Size(234, 24)
        Me.carpetatxt.TabIndex = 15
        '
        'boton_revisar
        '
        Me.boton_revisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_revisar.Image = Global.admintegral_interface.My.Resources.Resources.Search_2
        Me.boton_revisar.Location = New System.Drawing.Point(459, 3)
        Me.boton_revisar.Name = "boton_revisar"
        Me.boton_revisar.Size = New System.Drawing.Size(75, 69)
        Me.boton_revisar.TabIndex = 14
        Me.boton_revisar.UseVisualStyleBackColor = True
        '
        'lbldestino
        '
        Me.lbldestino.AutoSize = True
        Me.lbldestino.Location = New System.Drawing.Point(3, 179)
        Me.lbldestino.Name = "lbldestino"
        Me.lbldestino.Size = New System.Drawing.Size(39, 13)
        Me.lbldestino.TabIndex = 13
        Me.lbldestino.Text = "Label3"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(365, 206)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(57, 26)
        Me.dgv.TabIndex = 13
        '
        'Folder
        '
        Me.Folder.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Location = New System.Drawing.Point(343, 15)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(34, 13)
        SerieLabel.TabIndex = 18
        SerieLabel.Text = "Serie:"
        '
        'SerieTextBox
        '
        Me.SerieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "Serie", True))
        Me.SerieTextBox.Enabled = False
        Me.SerieTextBox.Location = New System.Drawing.Point(383, 12)
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.Size = New System.Drawing.Size(37, 20)
        Me.SerieTextBox.TabIndex = 19
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(650, 328)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.boton_salir)
        Me.Controls.Add(Me.dgv)
        Me.Name = "ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descargar Ventas de las Sucursales"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_setup As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_salir As System.Windows.Forms.Button
    Friend WithEvents IntegraDataSet As admintegral_interface.integraDataSet
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As admintegral_interface.integraDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents filetxt As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_caja As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents status As System.Windows.Forms.ToolStripLabel
    Friend WithEvents boton_descargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents boton_aplicar As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_end As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lbldestino As System.Windows.Forms.Label
    Friend WithEvents boton_revisar As System.Windows.Forms.Button
    Friend WithEvents carpetatxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Folder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents boton_borrar As System.Windows.Forms.Button
    Friend WithEvents boton_copiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
End Class
