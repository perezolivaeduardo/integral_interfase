<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_caja
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Id_caja = New System.Windows.Forms.TextBox
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntegraDataSet = New admintegral_interface.integraDataSet
        Me.caja = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.boton_todos = New System.Windows.Forms.Button
        Me.boton_resumen = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.file = New System.Windows.Forms.ToolStripStatusLabel
        Me.CajasTableAdapter = New admintegral_interface.integraDataSetTableAdapters.cajasTableAdapter
        Me.filtrotxt = New System.Windows.Forms.TextBox
        Me.aplicar_filtro = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_caja)
        Me.SplitContainer1.Panel1.Controls.Add(Me.caja)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(587, 356)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 0
        '
        'Id_caja
        '
        Me.Id_caja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "id_caja", True))
        Me.Id_caja.Location = New System.Drawing.Point(357, 12)
        Me.Id_caja.Name = "Id_caja"
        Me.Id_caja.Size = New System.Drawing.Size(33, 20)
        Me.Id_caja.TabIndex = 15
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
        'caja
        '
        Me.caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja.Location = New System.Drawing.Point(64, 9)
        Me.caja.Name = "caja"
        Me.caja.Size = New System.Drawing.Size(48, 24)
        Me.caja.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Caja :"
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.CajasBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(117, 8)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(234, 26)
        Me.NombreComboBox.TabIndex = 11
        Me.NombreComboBox.ValueMember = "id_caja"
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(465, 7)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(110, 24)
        Me.fecha.TabIndex = 12
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_todos)
        Me.SplitContainer2.Panel1.Controls.Add(Me.boton_resumen)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.aplicar_filtro)
        Me.SplitContainer2.Panel2.Controls.Add(Me.filtrotxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(587, 289)
        Me.SplitContainer2.SplitterDistance = 150
        Me.SplitContainer2.TabIndex = 1
        '
        'boton_todos
        '
        Me.boton_todos.Location = New System.Drawing.Point(3, 32)
        Me.boton_todos.Name = "boton_todos"
        Me.boton_todos.Size = New System.Drawing.Size(144, 23)
        Me.boton_todos.TabIndex = 1
        Me.boton_todos.Text = "Todos los Doc de la Caja"
        Me.boton_todos.UseVisualStyleBackColor = True
        '
        'boton_resumen
        '
        Me.boton_resumen.Location = New System.Drawing.Point(1, 3)
        Me.boton_resumen.Name = "boton_resumen"
        Me.boton_resumen.Size = New System.Drawing.Size(147, 23)
        Me.boton_resumen.TabIndex = 1
        Me.boton_resumen.Text = "Resumen Doc. Fecha"
        Me.boton_resumen.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(433, 226)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(425, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(419, 194)
        Me.dgv.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(425, 200)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 289)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(587, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'file
        '
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(121, 17)
        Me.file.Text = "ToolStripStatusLabel1"
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'filtrotxt
        '
        Me.filtrotxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.filtrotxt.Location = New System.Drawing.Point(0, 226)
        Me.filtrotxt.Name = "filtrotxt"
        Me.filtrotxt.Size = New System.Drawing.Size(433, 20)
        Me.filtrotxt.TabIndex = 1
        '
        'aplicar_filtro
        '
        Me.aplicar_filtro.Location = New System.Drawing.Point(4, 252)
        Me.aplicar_filtro.Name = "aplicar_filtro"
        Me.aplicar_filtro.Size = New System.Drawing.Size(75, 23)
        Me.aplicar_filtro.TabIndex = 2
        Me.aplicar_filtro.Text = "Aplicar_Filtro"
        Me.aplicar_filtro.UseVisualStyleBackColor = True
        '
        'info_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 356)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "info_caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "info_caja"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IntegraDataSet As admintegral_interface.integraDataSet
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As admintegral_interface.integraDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents caja As System.Windows.Forms.TextBox
    Friend WithEvents Id_caja As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents file As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents boton_resumen As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents boton_todos As System.Windows.Forms.Button
    Friend WithEvents aplicar_filtro As System.Windows.Forms.Button
    Friend WithEvents filtrotxt As System.Windows.Forms.TextBox
End Class
