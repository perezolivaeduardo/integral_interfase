<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enviar_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enviar_info))
        Me.boton_subir = New System.Windows.Forms.ToolStrip
        Me.boton_ftp = New System.Windows.Forms.ToolStripButton
        Me.boton_USB = New System.Windows.Forms.ToolStripButton
        Me.boton_setup = New System.Windows.Forms.ToolStripButton
        Me.boton_end = New System.Windows.Forms.ToolStripButton
        Me.lista = New System.Windows.Forms.CheckedListBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New admintegral_interface.integraDataSet
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lista_sys = New System.Windows.Forms.ListBox
        Me.pathtxt = New System.Windows.Forms.TextBox
        Me.CajasTableAdapter = New admintegral_interface.integraDataSetTableAdapters.cajasTableAdapter
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        NombreLabel = New System.Windows.Forms.Label
        Me.boton_subir.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(15, 60)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 11
        NombreLabel.Text = "Nombre:"
        '
        'boton_subir
        '
        Me.boton_subir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.boton_subir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.boton_subir.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.boton_subir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.boton_ftp, Me.boton_USB, Me.boton_setup, Me.boton_end})
        Me.boton_subir.Location = New System.Drawing.Point(0, 286)
        Me.boton_subir.Name = "boton_subir"
        Me.boton_subir.Size = New System.Drawing.Size(574, 71)
        Me.boton_subir.TabIndex = 5
        Me.boton_subir.Text = "ToolStrip1"
        '
        'boton_ftp
        '
        Me.boton_ftp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.boton_ftp.Image = CType(resources.GetObject("boton_ftp.Image"), System.Drawing.Image)
        Me.boton_ftp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_ftp.Name = "boton_ftp"
        Me.boton_ftp.Size = New System.Drawing.Size(160, 68)
        Me.boton_ftp.Text = "Subir al Servidor"
        '
        'boton_USB
        '
        Me.boton_USB.Image = CType(resources.GetObject("boton_USB.Image"), System.Drawing.Image)
        Me.boton_USB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_USB.Name = "boton_USB"
        Me.boton_USB.Size = New System.Drawing.Size(143, 68)
        Me.boton_USB.Text = "Copiar a USB"
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
        Me.boton_end.Image = CType(resources.GetObject("boton_end.Image"), System.Drawing.Image)
        Me.boton_end.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_end.Name = "boton_end"
        Me.boton_end.Size = New System.Drawing.Size(68, 68)
        Me.boton_end.Text = "ToolStripButton1"
        '
        'lista
        '
        Me.lista.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lista.Dock = System.Windows.Forms.DockStyle.Left
        Me.lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista.ForeColor = System.Drawing.Color.White
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(3, 3)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(226, 232)
        Me.lista.TabIndex = 7
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(574, 266)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(566, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Catalogos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(NombreLabel)
        Me.TabPage2.Controls.Add(Me.NombreComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(566, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listas de Precios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seleccione la tienda a la que quiere mandar los datos :"
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.CajasBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(90, 56)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(286, 28)
        Me.NombreComboBox.TabIndex = 12
        Me.NombreComboBox.ValueMember = "id_caja"
        '
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.IntegraDataSet
        '
        'IntegraDataSet
        '
        Me.IntegraDataSet.DataSetName = "integraDataSet"
        Me.IntegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage3.Controls.Add(Me.lista_sys)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(566, 240)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tablas del Sistema"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lista_sys
        '
        Me.lista_sys.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lista_sys.Dock = System.Windows.Forms.DockStyle.Left
        Me.lista_sys.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_sys.FormattingEnabled = True
        Me.lista_sys.ItemHeight = 18
        Me.lista_sys.Location = New System.Drawing.Point(0, 0)
        Me.lista_sys.Name = "lista_sys"
        Me.lista_sys.Size = New System.Drawing.Size(267, 238)
        Me.lista_sys.TabIndex = 0
        '
        'pathtxt
        '
        Me.pathtxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pathtxt.Location = New System.Drawing.Point(0, 266)
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.ReadOnly = True
        Me.pathtxt.Size = New System.Drawing.Size(574, 20)
        Me.pathtxt.TabIndex = 9
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Direccion USB"
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Enviar_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(574, 357)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pathtxt)
        Me.Controls.Add(Me.boton_subir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Enviar_info"
        Me.Text = "Enviar_info"
        Me.boton_subir.ResumeLayout(False)
        Me.boton_subir.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boton_subir As System.Windows.Forms.ToolStrip
    Friend WithEvents boton_ftp As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_USB As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_setup As System.Windows.Forms.ToolStripButton
    Friend WithEvents boton_end As System.Windows.Forms.ToolStripButton
    Friend WithEvents lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IntegraDataSet As admintegral_interface.integraDataSet
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As admintegral_interface.integraDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents pathtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lista_sys As System.Windows.Forms.ListBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
End Class
