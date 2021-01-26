<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedidos
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.boton_Export = New System.Windows.Forms.ToolStripButton
        Me.boton_setup = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.chclientes = New System.Windows.Forms.CheckBox
        Me.chfacturas = New System.Windows.Forms.CheckBox
        Me.chproductos = New System.Windows.Forms.CheckBox
        Me.chgrupos = New System.Windows.Forms.CheckBox
        Me.path = New System.Windows.Forms.LinkLabel
        Me.iproducto = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.igrupo = New System.Windows.Forms.PictureBox
        Me.ifactura = New System.Windows.Forms.PictureBox
        Me.icliente = New System.Windows.Forms.PictureBox
        Me.IntegraDataSet = New admintegral_interface.integraDataSet
        Me.AgentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentesTableAdapter = New admintegral_interface.integraDataSetTableAdapters.AgentesTableAdapter
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.ilista = New System.Windows.Forms.PictureBox
        Me.chlista = New System.Windows.Forms.CheckBox
        Me.iexistencia = New System.Windows.Forms.PictureBox
        Me.chexistencia = New System.Windows.Forms.CheckBox
        Me.Id_agenteTextBox = New System.Windows.Forms.TextBox
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        NombreLabel = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.iproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.igrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ifactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ilista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iexistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(12, 9)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(61, 20)
        NombreLabel.TabIndex = 16
        NombreLabel.Text = "Agente"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_Export, Me.boton_setup, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 346)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(627, 71)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'boton_Export
        '
        Me.boton_Export.Image = Global.admintegral_interface.My.Resources.Resources._Next
        Me.boton_Export.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_Export.Name = "boton_Export"
        Me.boton_Export.Size = New System.Drawing.Size(152, 68)
        Me.boton_Export.Text = "Crera Archivos"
        Me.boton_Export.ToolTipText = "Visita al Cliente"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.admintegral_interface.My.Resources.Resources.Log_Off
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.admintegral_interface.My.Resources.Resources.Up___Down
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(151, 68)
        Me.ToolStripButton2.Text = "Subir Archivos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccione los archivos que va a Publicar"
        '
        'chclientes
        '
        Me.chclientes.AutoSize = True
        Me.chclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chclientes.Location = New System.Drawing.Point(36, 102)
        Me.chclientes.Name = "chclientes"
        Me.chclientes.Size = New System.Drawing.Size(85, 24)
        Me.chclientes.TabIndex = 6
        Me.chclientes.Text = "Clientes"
        Me.chclientes.UseVisualStyleBackColor = True
        '
        'chfacturas
        '
        Me.chfacturas.AutoSize = True
        Me.chfacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chfacturas.Location = New System.Drawing.Point(36, 132)
        Me.chfacturas.Name = "chfacturas"
        Me.chfacturas.Size = New System.Drawing.Size(91, 24)
        Me.chfacturas.TabIndex = 7
        Me.chfacturas.Text = "Facturas"
        Me.chfacturas.UseVisualStyleBackColor = True
        '
        'chproductos
        '
        Me.chproductos.AutoSize = True
        Me.chproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chproductos.Location = New System.Drawing.Point(36, 162)
        Me.chproductos.Name = "chproductos"
        Me.chproductos.Size = New System.Drawing.Size(104, 24)
        Me.chproductos.TabIndex = 8
        Me.chproductos.Text = "Productos "
        Me.chproductos.UseVisualStyleBackColor = True
        '
        'chgrupos
        '
        Me.chgrupos.AutoSize = True
        Me.chgrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chgrupos.Location = New System.Drawing.Point(36, 192)
        Me.chgrupos.Name = "chgrupos"
        Me.chgrupos.Size = New System.Drawing.Size(81, 24)
        Me.chgrupos.TabIndex = 9
        Me.chgrupos.Text = "Grupos"
        Me.chgrupos.UseVisualStyleBackColor = True
        '
        'path
        '
        Me.path.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.path.AutoSize = True
        Me.path.DisabledLinkColor = System.Drawing.Color.Blue
        Me.path.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.path.Location = New System.Drawing.Point(5, 333)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(141, 16)
        Me.path.TabIndex = 11
        Me.path.TabStop = True
        Me.path.Text = "Detino de los archivos"
        Me.path.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'iproducto
        '
        Me.iproducto.Image = Global.admintegral_interface.My.Resources.Resources.Ok_2
        Me.iproducto.Location = New System.Drawing.Point(146, 162)
        Me.iproducto.Name = "iproducto"
        Me.iproducto.Size = New System.Drawing.Size(34, 24)
        Me.iproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iproducto.TabIndex = 12
        Me.iproducto.TabStop = False
        Me.iproducto.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.admintegral_interface.My.Resources.Resources.Mac
        Me.PictureBox1.Location = New System.Drawing.Point(499, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'igrupo
        '
        Me.igrupo.Image = Global.admintegral_interface.My.Resources.Resources.Ok_2
        Me.igrupo.Location = New System.Drawing.Point(146, 192)
        Me.igrupo.Name = "igrupo"
        Me.igrupo.Size = New System.Drawing.Size(34, 24)
        Me.igrupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.igrupo.TabIndex = 13
        Me.igrupo.TabStop = False
        Me.igrupo.Visible = False
        '
        'ifactura
        '
        Me.ifactura.Image = Global.admintegral_interface.My.Resources.Resources.Ok_2
        Me.ifactura.Location = New System.Drawing.Point(146, 132)
        Me.ifactura.Name = "ifactura"
        Me.ifactura.Size = New System.Drawing.Size(34, 24)
        Me.ifactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ifactura.TabIndex = 14
        Me.ifactura.TabStop = False
        Me.ifactura.Visible = False
        '
        'icliente
        '
        Me.icliente.Image = Global.admintegral_interface.My.Resources.Resources.Ok_2
        Me.icliente.Location = New System.Drawing.Point(146, 102)
        Me.icliente.Name = "icliente"
        Me.icliente.Size = New System.Drawing.Size(34, 24)
        Me.icliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.icliente.TabIndex = 15
        Me.icliente.TabStop = False
        Me.icliente.Visible = False
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentesBindingSource
        '
        Me.AgentesBindingSource.DataMember = "Agentes"
        Me.AgentesBindingSource.DataSource = Me.IntegraDataSet
        '
        'AgentesTableAdapter
        '
        Me.AgentesTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.AgentesBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(16, 36)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(424, 28)
        Me.NombreComboBox.TabIndex = 17
        Me.NombreComboBox.ValueMember = "id_agente"
        '
        'ilista
        '
        Me.ilista.Image = Global.admintegral_interface.My.Resources.Resources.Ok_2
        Me.ilista.Location = New System.Drawing.Point(146, 252)
        Me.ilista.Name = "ilista"
        Me.ilista.Size = New System.Drawing.Size(34, 24)
        Me.ilista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ilista.TabIndex = 19
        Me.ilista.TabStop = False
        Me.ilista.Visible = False
        '
        'chlista
        '
        Me.chlista.AutoSize = True
        Me.chlista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlista.Location = New System.Drawing.Point(36, 252)
        Me.chlista.Name = "chlista"
        Me.chlista.Size = New System.Drawing.Size(80, 24)
        Me.chlista.TabIndex = 18
        Me.chlista.Text = "Precios"
        Me.chlista.UseVisualStyleBackColor = True
        Me.chlista.Visible = False
        '
        'iexistencia
        '
        Me.iexistencia.Image = Global.admintegral_interface.My.Resources.Resources.Ok_2
        Me.iexistencia.Location = New System.Drawing.Point(146, 222)
        Me.iexistencia.Name = "iexistencia"
        Me.iexistencia.Size = New System.Drawing.Size(34, 24)
        Me.iexistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iexistencia.TabIndex = 21
        Me.iexistencia.TabStop = False
        Me.iexistencia.Visible = False
        '
        'chexistencia
        '
        Me.chexistencia.AutoSize = True
        Me.chexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chexistencia.Location = New System.Drawing.Point(36, 222)
        Me.chexistencia.Name = "chexistencia"
        Me.chexistencia.Size = New System.Drawing.Size(108, 24)
        Me.chexistencia.TabIndex = 20
        Me.chexistencia.Text = "Existencias"
        Me.chexistencia.UseVisualStyleBackColor = True
        '
        'Id_agenteTextBox
        '
        Me.Id_agenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgentesBindingSource, "id_agente", True))
        Me.Id_agenteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_agenteTextBox.Location = New System.Drawing.Point(79, 9)
        Me.Id_agenteTextBox.Name = "Id_agenteTextBox"
        Me.Id_agenteTextBox.ReadOnly = True
        Me.Id_agenteTextBox.Size = New System.Drawing.Size(48, 22)
        Me.Id_agenteTextBox.TabIndex = 22
        '
        'pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(627, 417)
        Me.Controls.Add(Me.Id_agenteTextBox)
        Me.Controls.Add(Me.iexistencia)
        Me.Controls.Add(Me.chexistencia)
        Me.Controls.Add(Me.ilista)
        Me.Controls.Add(Me.chlista)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.icliente)
        Me.Controls.Add(Me.ifactura)
        Me.Controls.Add(Me.igrupo)
        Me.Controls.Add(Me.iproducto)
        Me.Controls.Add(Me.path)
        Me.Controls.Add(Me.chgrupos)
        Me.Controls.Add(Me.chproductos)
        Me.Controls.Add(Me.chfacturas)
        Me.Controls.Add(Me.chclientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administacion del modulo de Pedidos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.iproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.igrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ifactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ilista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iexistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_Export As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_setup As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chclientes As System.Windows.Forms.CheckBox
    Friend WithEvents chfacturas As System.Windows.Forms.CheckBox
    Friend WithEvents chproductos As System.Windows.Forms.CheckBox
    Friend WithEvents chgrupos As System.Windows.Forms.CheckBox
    Friend WithEvents path As System.Windows.Forms.LinkLabel
    Friend WithEvents iproducto As System.Windows.Forms.PictureBox
    Friend WithEvents igrupo As System.Windows.Forms.PictureBox
    Friend WithEvents ifactura As System.Windows.Forms.PictureBox
    Friend WithEvents icliente As System.Windows.Forms.PictureBox
    Friend WithEvents IntegraDataSet As admintegral_interface.integraDataSet
    Friend WithEvents AgentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgentesTableAdapter As admintegral_interface.integraDataSetTableAdapters.AgentesTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ilista As System.Windows.Forms.PictureBox
    Friend WithEvents chlista As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents iexistencia As System.Windows.Forms.PictureBox
    Friend WithEvents chexistencia As System.Windows.Forms.CheckBox
    Friend WithEvents Id_agenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
End Class
