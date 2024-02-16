<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionActaDeMatrimonio
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(InformacionActaDeMatrimonio))
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        btnGenerar = New DataGridViewButtonColumn()
        btnEditar = New DataGridViewButtonColumn()
        btnEliminar = New DataGridViewButtonColumn()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        ActasDeConfirmaciónToolStripMenuItem = New ToolStripMenuItem()
        FeDeBautismoToolStripMenuItem = New ToolStripMenuItem()
        ActaDeMatrimonioToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        BaseDeDatosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        actaMatrimonioBuscador = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(610, 51)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 48)
        Button2.TabIndex = 50
        Button2.Text = "Regresar al menú principal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(430, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 48)
        Button1.TabIndex = 49
        Button1.Text = "Agregar nueva acta de matrimonio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(74, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 25)
        Label1.TabIndex = 48
        Label1.Text = "Buscador"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(333, 105)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Busca por nombre"
        TextBox1.Size = New Size(432, 25)
        TextBox1.TabIndex = 47
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {btnGenerar, btnEditar, btnEliminar})
        DataGridView1.Location = New Point(12, 151)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(776, 352)
        DataGridView1.TabIndex = 46
        ' 
        ' btnGenerar
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Lime
        DataGridViewCellStyle1.SelectionBackColor = Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        btnGenerar.DefaultCellStyle = DataGridViewCellStyle1
        btnGenerar.HeaderText = "Generar acta"
        btnGenerar.Name = "btnGenerar"
        btnGenerar.ReadOnly = True
        btnGenerar.Text = "Generar"
        btnGenerar.UseColumnTextForButtonValue = True
        btnGenerar.Width = 93
        ' 
        ' btnEditar
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Yellow
        DataGridViewCellStyle2.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        btnEditar.DefaultCellStyle = DataGridViewCellStyle2
        btnEditar.HeaderText = "Editar acta"
        btnEditar.Name = "btnEditar"
        btnEditar.ReadOnly = True
        btnEditar.Text = "Editar"
        btnEditar.UseColumnTextForButtonValue = True
        btnEditar.Width = 79
        ' 
        ' btnEliminar
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        btnEliminar.DefaultCellStyle = DataGridViewCellStyle3
        btnEliminar.HeaderText = "Eliminar acta"
        btnEliminar.Name = "btnEliminar"
        btnEliminar.ReadOnly = True
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseColumnTextForButtonValue = True
        btnEliminar.Width = 92
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ConfiguraciónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 45
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActasDeConfirmaciónToolStripMenuItem, FeDeBautismoToolStripMenuItem, ActaDeMatrimonioToolStripMenuItem})
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(48, 20)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' ActasDeConfirmaciónToolStripMenuItem
        ' 
        ActasDeConfirmaciónToolStripMenuItem.Name = "ActasDeConfirmaciónToolStripMenuItem"
        ActasDeConfirmaciónToolStripMenuItem.Size = New Size(180, 22)
        ActasDeConfirmaciónToolStripMenuItem.Text = "Acta de confirma"
        ' 
        ' FeDeBautismoToolStripMenuItem
        ' 
        FeDeBautismoToolStripMenuItem.Name = "FeDeBautismoToolStripMenuItem"
        FeDeBautismoToolStripMenuItem.Size = New Size(180, 22)
        FeDeBautismoToolStripMenuItem.Text = "Fe de bautismo"
        ' 
        ' ActaDeMatrimonioToolStripMenuItem
        ' 
        ActaDeMatrimonioToolStripMenuItem.Enabled = False
        ActaDeMatrimonioToolStripMenuItem.Name = "ActaDeMatrimonioToolStripMenuItem"
        ActaDeMatrimonioToolStripMenuItem.Size = New Size(180, 22)
        ActaDeMatrimonioToolStripMenuItem.Text = "Acta de matrimonio"
        ' 
        ' ConfiguraciónToolStripMenuItem
        ' 
        ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BaseDeDatosToolStripMenuItem})
        ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        ConfiguraciónToolStripMenuItem.Size = New Size(95, 20)
        ConfiguraciónToolStripMenuItem.Text = "Configuración"
        ' 
        ' BaseDeDatosToolStripMenuItem
        ' 
        BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        BaseDeDatosToolStripMenuItem.Size = New Size(146, 22)
        BaseDeDatosToolStripMenuItem.Text = "Base de datos"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' actaMatrimonioBuscador
        ' 
        actaMatrimonioBuscador.DropDownStyle = ComboBoxStyle.DropDownList
        actaMatrimonioBuscador.FormattingEnabled = True
        actaMatrimonioBuscador.Location = New Point(170, 105)
        actaMatrimonioBuscador.Name = "actaMatrimonioBuscador"
        actaMatrimonioBuscador.Size = New Size(157, 25)
        actaMatrimonioBuscador.TabIndex = 51
        ' 
        ' InformacionActaDeMatrimonio
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 510)
        Controls.Add(actaMatrimonioBuscador)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "InformacionActaDeMatrimonio"
        Text = "Acta de matrimonio"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActasDeConfirmaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeDeBautismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActaDeMatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents actaMatrimonioBuscador As ComboBox
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGenerar As DataGridViewButtonColumn
    Friend WithEvents btnEditar As DataGridViewButtonColumn
    Friend WithEvents btnEliminar As DataGridViewButtonColumn
End Class
