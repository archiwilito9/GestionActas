<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarActaMatrimonio
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
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        ActasDeConfirmaciónToolStripMenuItem = New ToolStripMenuItem()
        FeDeBautismoToolStripMenuItem = New ToolStripMenuItem()
        ActaDeMatrimonioToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        BaseDeDatosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        actaMatrimonioGBPadresNovia = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        actaMatrimonioEdadNovia = New TextBox()
        actaMatrimonioNombreNovia = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        actaMatrimonioDepartamentoNovia = New ComboBox()
        Label6 = New Label()
        actaMatrimonioNombreMadreNovia = New TextBox()
        Label7 = New Label()
        actaMatrimonioNombrePadreNovia = New TextBox()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        actaMatrimonioGBPadresNovio = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        actaMatrimonioEdadNovio = New TextBox()
        actaMatrimonioNombreNovio = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        actaMatrimonioDepartamentoNovio = New ComboBox()
        Label15 = New Label()
        actaMatrimonioNombreMadreNovio = New TextBox()
        Label16 = New Label()
        actaMatrimonioNombrePadreNovio = New TextBox()
        Label17 = New Label()
        actaMatrimonioGBPadrinos = New GroupBox()
        actaConfirmaMultiplesPadrinos = New RadioButton()
        actaConfirmaMadrina = New RadioButton()
        actaConfirmaPadrino = New RadioButton()
        actaMatrimonioAdministradorMatrimonio = New TextBox()
        Label12 = New Label()
        Button2 = New Button()
        btnActaMatrimonioGenerar = New Button()
        actaMatrimonioNombrePadrino = New TextBox()
        actaMatrimonioNumeroActa = New TextBox()
        actaMatrimonioNumeroLibro = New TextBox()
        actaMatrimonioFechaExtension = New DateTimePicker()
        Label10 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        actaMatrimonioFechaMatrimonio = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        actaMatrimonioGBPadresNovia.SuspendLayout()
        GroupBox2.SuspendLayout()
        actaMatrimonioGBPadresNovio.SuspendLayout()
        actaMatrimonioGBPadrinos.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ConfiguraciónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1119, 24)
        MenuStrip1.TabIndex = 88
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(actaMatrimonioGBPadresNovia)
        GroupBox1.Controls.Add(actaMatrimonioEdadNovia)
        GroupBox1.Controls.Add(actaMatrimonioNombreNovia)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(actaMatrimonioDepartamentoNovia)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(actaMatrimonioNombreMadreNovia)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(actaMatrimonioNombrePadreNovia)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(573, 181)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(506, 275)
        GroupBox1.TabIndex = 87
        GroupBox1.TabStop = False
        GroupBox1.Text = "Información de la novia"
        ' 
        ' actaMatrimonioGBPadresNovia
        ' 
        actaMatrimonioGBPadresNovia.Controls.Add(RadioButton4)
        actaMatrimonioGBPadresNovia.Controls.Add(RadioButton5)
        actaMatrimonioGBPadresNovia.Controls.Add(RadioButton6)
        actaMatrimonioGBPadresNovia.Location = New Point(177, 101)
        actaMatrimonioGBPadresNovia.Name = "actaMatrimonioGBPadresNovia"
        actaMatrimonioGBPadresNovia.Size = New Size(314, 51)
        actaMatrimonioGBPadresNovia.TabIndex = 70
        actaMatrimonioGBPadresNovia.TabStop = False
        actaMatrimonioGBPadresNovia.Text = "Padres de la novia"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(216, 19)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(92, 23)
        RadioButton4.TabIndex = 2
        RadioButton4.Text = "Solo padre"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(120, 19)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(96, 23)
        RadioButton5.TabIndex = 1
        RadioButton5.Text = "Solo madre"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Checked = True
        RadioButton6.Location = New Point(9, 19)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(115, 23)
        RadioButton6.TabIndex = 0
        RadioButton6.TabStop = True
        RadioButton6.Text = "Ambos padres"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' actaMatrimonioEdadNovia
        ' 
        actaMatrimonioEdadNovia.Location = New Point(205, 68)
        actaMatrimonioEdadNovia.Name = "actaMatrimonioEdadNovia"
        actaMatrimonioEdadNovia.PlaceholderText = "Edad de la novia"
        actaMatrimonioEdadNovia.Size = New Size(266, 25)
        actaMatrimonioEdadNovia.TabIndex = 69
        ' 
        ' actaMatrimonioNombreNovia
        ' 
        actaMatrimonioNombreNovia.Location = New Point(205, 34)
        actaMatrimonioNombreNovia.Name = "actaMatrimonioNombreNovia"
        actaMatrimonioNombreNovia.PlaceholderText = "Nombre de la novia"
        actaMatrimonioNombreNovia.Size = New Size(266, 25)
        actaMatrimonioNombreNovia.TabIndex = 55
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 19)
        Label3.TabIndex = 68
        Label3.Text = "Edad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 19)
        Label5.TabIndex = 43
        Label5.Text = "Nombre completo"
        ' 
        ' actaMatrimonioDepartamentoNovia
        ' 
        actaMatrimonioDepartamentoNovia.DisplayMember = "gg"
        actaMatrimonioDepartamentoNovia.DropDownStyle = ComboBoxStyle.DropDownList
        actaMatrimonioDepartamentoNovia.FormattingEnabled = True
        actaMatrimonioDepartamentoNovia.Location = New Point(205, 230)
        actaMatrimonioDepartamentoNovia.Name = "actaMatrimonioDepartamentoNovia"
        actaMatrimonioDepartamentoNovia.Size = New Size(266, 25)
        actaMatrimonioDepartamentoNovia.TabIndex = 59
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 233)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 19)
        Label6.TabIndex = 44
        Label6.Text = "Departamento de nacimiento"
        ' 
        ' actaMatrimonioNombreMadreNovia
        ' 
        actaMatrimonioNombreMadreNovia.Location = New Point(205, 195)
        actaMatrimonioNombreMadreNovia.Name = "actaMatrimonioNombreMadreNovia"
        actaMatrimonioNombreMadreNovia.PlaceholderText = "Madre de la novia"
        actaMatrimonioNombreMadreNovia.Size = New Size(266, 25)
        actaMatrimonioNombreMadreNovia.TabIndex = 56
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 19)
        Label7.TabIndex = 45
        Label7.Text = "Nombre del padre"
        ' 
        ' actaMatrimonioNombrePadreNovia
        ' 
        actaMatrimonioNombrePadreNovia.Location = New Point(205, 165)
        actaMatrimonioNombrePadreNovia.Name = "actaMatrimonioNombrePadreNovia"
        actaMatrimonioNombrePadreNovia.PlaceholderText = "Padre de la novia"
        actaMatrimonioNombrePadreNovia.Size = New Size(266, 25)
        actaMatrimonioNombrePadreNovia.TabIndex = 57
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 195)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 19)
        Label8.TabIndex = 46
        Label8.Text = "Nombre de la madre"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(actaMatrimonioGBPadresNovio)
        GroupBox2.Controls.Add(actaMatrimonioEdadNovio)
        GroupBox2.Controls.Add(actaMatrimonioNombreNovio)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(actaMatrimonioDepartamentoNovio)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(actaMatrimonioNombreMadreNovio)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(actaMatrimonioNombrePadreNovio)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(45, 181)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(506, 275)
        GroupBox2.TabIndex = 86
        GroupBox2.TabStop = False
        GroupBox2.Text = "Información del novio"
        ' 
        ' actaMatrimonioGBPadresNovio
        ' 
        actaMatrimonioGBPadresNovio.Controls.Add(RadioButton1)
        actaMatrimonioGBPadresNovio.Controls.Add(RadioButton2)
        actaMatrimonioGBPadresNovio.Controls.Add(RadioButton3)
        actaMatrimonioGBPadresNovio.Location = New Point(177, 101)
        actaMatrimonioGBPadresNovio.Name = "actaMatrimonioGBPadresNovio"
        actaMatrimonioGBPadresNovio.Size = New Size(314, 51)
        actaMatrimonioGBPadresNovio.TabIndex = 70
        actaMatrimonioGBPadresNovio.TabStop = False
        actaMatrimonioGBPadresNovio.Text = "Padres del novio"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(216, 19)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(92, 23)
        RadioButton1.TabIndex = 2
        RadioButton1.Text = "Solo padre"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(120, 19)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(96, 23)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "Solo madre"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Checked = True
        RadioButton3.Location = New Point(9, 19)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(115, 23)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Ambos padres"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' actaMatrimonioEdadNovio
        ' 
        actaMatrimonioEdadNovio.Location = New Point(205, 68)
        actaMatrimonioEdadNovio.Name = "actaMatrimonioEdadNovio"
        actaMatrimonioEdadNovio.PlaceholderText = "Edad del novio"
        actaMatrimonioEdadNovio.Size = New Size(266, 25)
        actaMatrimonioEdadNovio.TabIndex = 69
        ' 
        ' actaMatrimonioNombreNovio
        ' 
        actaMatrimonioNombreNovio.Location = New Point(205, 34)
        actaMatrimonioNombreNovio.Name = "actaMatrimonioNombreNovio"
        actaMatrimonioNombreNovio.PlaceholderText = "Nombre del novio"
        actaMatrimonioNombreNovio.Size = New Size(266, 25)
        actaMatrimonioNombreNovio.TabIndex = 55
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(10, 77)
        Label13.Name = "Label13"
        Label13.Size = New Size(39, 19)
        Label13.TabIndex = 68
        Label13.Text = "Edad"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(8, 34)
        Label14.Name = "Label14"
        Label14.Size = New Size(120, 19)
        Label14.TabIndex = 43
        Label14.Text = "Nombre completo"
        ' 
        ' actaMatrimonioDepartamentoNovio
        ' 
        actaMatrimonioDepartamentoNovio.DisplayMember = "gg"
        actaMatrimonioDepartamentoNovio.DropDownStyle = ComboBoxStyle.DropDownList
        actaMatrimonioDepartamentoNovio.FormattingEnabled = True
        actaMatrimonioDepartamentoNovio.Location = New Point(205, 230)
        actaMatrimonioDepartamentoNovio.Name = "actaMatrimonioDepartamentoNovio"
        actaMatrimonioDepartamentoNovio.Size = New Size(266, 25)
        actaMatrimonioDepartamentoNovio.TabIndex = 59
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(10, 233)
        Label15.Name = "Label15"
        Label15.Size = New Size(188, 19)
        Label15.TabIndex = 44
        Label15.Text = "Departamento de nacimiento"
        ' 
        ' actaMatrimonioNombreMadreNovio
        ' 
        actaMatrimonioNombreMadreNovio.Location = New Point(205, 198)
        actaMatrimonioNombreMadreNovio.Name = "actaMatrimonioNombreMadreNovio"
        actaMatrimonioNombreMadreNovio.PlaceholderText = "Madre del novio"
        actaMatrimonioNombreMadreNovio.Size = New Size(266, 25)
        actaMatrimonioNombreMadreNovio.TabIndex = 56
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(10, 168)
        Label16.Name = "Label16"
        Label16.Size = New Size(120, 19)
        Label16.TabIndex = 45
        Label16.Text = "Nombre del padre"
        ' 
        ' actaMatrimonioNombrePadreNovio
        ' 
        actaMatrimonioNombrePadreNovio.Location = New Point(205, 165)
        actaMatrimonioNombrePadreNovio.Name = "actaMatrimonioNombrePadreNovio"
        actaMatrimonioNombrePadreNovio.PlaceholderText = "Padre del novio"
        actaMatrimonioNombrePadreNovio.Size = New Size(266, 25)
        actaMatrimonioNombrePadreNovio.TabIndex = 57
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(10, 198)
        Label17.Name = "Label17"
        Label17.Size = New Size(135, 19)
        Label17.TabIndex = 46
        Label17.Text = "Nombre de la madre"
        ' 
        ' actaMatrimonioGBPadrinos
        ' 
        actaMatrimonioGBPadrinos.Controls.Add(actaConfirmaMultiplesPadrinos)
        actaMatrimonioGBPadrinos.Controls.Add(actaConfirmaMadrina)
        actaMatrimonioGBPadrinos.Controls.Add(actaConfirmaPadrino)
        actaMatrimonioGBPadrinos.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaMatrimonioGBPadrinos.Location = New Point(538, 478)
        actaMatrimonioGBPadrinos.Name = "actaMatrimonioGBPadrinos"
        actaMatrimonioGBPadrinos.Size = New Size(314, 51)
        actaMatrimonioGBPadrinos.TabIndex = 85
        actaMatrimonioGBPadrinos.TabStop = False
        actaMatrimonioGBPadrinos.Text = "Padrinos"
        ' 
        ' actaConfirmaMultiplesPadrinos
        ' 
        actaConfirmaMultiplesPadrinos.AutoSize = True
        actaConfirmaMultiplesPadrinos.Checked = True
        actaConfirmaMultiplesPadrinos.Location = New Point(6, 23)
        actaConfirmaMultiplesPadrinos.Name = "actaConfirmaMultiplesPadrinos"
        actaConfirmaMultiplesPadrinos.Size = New Size(140, 23)
        actaConfirmaMultiplesPadrinos.TabIndex = 5
        actaConfirmaMultiplesPadrinos.TabStop = True
        actaConfirmaMultiplesPadrinos.Text = "Múltiples padrinos"
        actaConfirmaMultiplesPadrinos.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaMadrina
        ' 
        actaConfirmaMadrina.AutoSize = True
        actaConfirmaMadrina.Location = New Point(149, 23)
        actaConfirmaMadrina.Name = "actaConfirmaMadrina"
        actaConfirmaMadrina.Size = New Size(78, 23)
        actaConfirmaMadrina.TabIndex = 4
        actaConfirmaMadrina.Text = "Madrina"
        actaConfirmaMadrina.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaPadrino
        ' 
        actaConfirmaPadrino.AutoSize = True
        actaConfirmaPadrino.Location = New Point(233, 23)
        actaConfirmaPadrino.Name = "actaConfirmaPadrino"
        actaConfirmaPadrino.Size = New Size(74, 23)
        actaConfirmaPadrino.TabIndex = 3
        actaConfirmaPadrino.Text = "Padrino"
        actaConfirmaPadrino.UseVisualStyleBackColor = True
        ' 
        ' actaMatrimonioAdministradorMatrimonio
        ' 
        actaMatrimonioAdministradorMatrimonio.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaMatrimonioAdministradorMatrimonio.Location = New Point(573, 142)
        actaMatrimonioAdministradorMatrimonio.Name = "actaMatrimonioAdministradorMatrimonio"
        actaMatrimonioAdministradorMatrimonio.PlaceholderText = "Administrador del matrimonio"
        actaMatrimonioAdministradorMatrimonio.Size = New Size(264, 25)
        actaMatrimonioAdministradorMatrimonio.TabIndex = 84
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(260, 151)
        Label12.Name = "Label12"
        Label12.Size = New Size(193, 19)
        Label12.TabIndex = 83
        Label12.Text = "Administrador del matrimonio"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(762, 598)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 82
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnActaMatrimonioGenerar
        ' 
        btnActaMatrimonioGenerar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnActaMatrimonioGenerar.Location = New Point(573, 598)
        btnActaMatrimonioGenerar.Name = "btnActaMatrimonioGenerar"
        btnActaMatrimonioGenerar.Size = New Size(75, 36)
        btnActaMatrimonioGenerar.TabIndex = 81
        btnActaMatrimonioGenerar.Text = "Guardar"
        btnActaMatrimonioGenerar.UseVisualStyleBackColor = True
        ' 
        ' actaMatrimonioNombrePadrino
        ' 
        actaMatrimonioNombrePadrino.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaMatrimonioNombrePadrino.Location = New Point(573, 536)
        actaMatrimonioNombrePadrino.Name = "actaMatrimonioNombrePadrino"
        actaMatrimonioNombrePadrino.PlaceholderText = "Nombre del padrin@/s"
        actaMatrimonioNombrePadrino.Size = New Size(264, 25)
        actaMatrimonioNombrePadrino.TabIndex = 80
        ' 
        ' actaMatrimonioNumeroActa
        ' 
        actaMatrimonioNumeroActa.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaMatrimonioNumeroActa.Location = New Point(573, 70)
        actaMatrimonioNumeroActa.Name = "actaMatrimonioNumeroActa"
        actaMatrimonioNumeroActa.PlaceholderText = "Acta"
        actaMatrimonioNumeroActa.Size = New Size(264, 25)
        actaMatrimonioNumeroActa.TabIndex = 79
        ' 
        ' actaMatrimonioNumeroLibro
        ' 
        actaMatrimonioNumeroLibro.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaMatrimonioNumeroLibro.Location = New Point(573, 38)
        actaMatrimonioNumeroLibro.Name = "actaMatrimonioNumeroLibro"
        actaMatrimonioNumeroLibro.PlaceholderText = "Libro"
        actaMatrimonioNumeroLibro.Size = New Size(264, 25)
        actaMatrimonioNumeroLibro.TabIndex = 78
        ' 
        ' actaMatrimonioFechaExtension
        ' 
        actaMatrimonioFechaExtension.CalendarFont = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaMatrimonioFechaExtension.Location = New Point(573, 565)
        actaMatrimonioFechaExtension.Name = "actaMatrimonioFechaExtension"
        actaMatrimonioFechaExtension.Size = New Size(264, 23)
        actaMatrimonioFechaExtension.TabIndex = 77
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(260, 574)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 19)
        Label10.TabIndex = 76
        Label10.Text = "Fecha de extensión"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(260, 541)
        Label9.Name = "Label9"
        Label9.Size = New Size(245, 19)
        Label9.TabIndex = 75
        Label9.Text = "Nombre del padrino/madrina/padrinos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(260, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 19)
        Label4.TabIndex = 74
        Label4.Text = "Fecha de bendición del matrimonio"
        ' 
        ' actaMatrimonioFechaMatrimonio
        ' 
        actaMatrimonioFechaMatrimonio.Location = New Point(573, 103)
        actaMatrimonioFechaMatrimonio.Name = "actaMatrimonioFechaMatrimonio"
        actaMatrimonioFechaMatrimonio.Size = New Size(264, 23)
        actaMatrimonioFechaMatrimonio.TabIndex = 73
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(260, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 19)
        Label2.TabIndex = 72
        Label2.Text = "Acta"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(260, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 19)
        Label1.TabIndex = 71
        Label1.Text = "Libro"
        ' 
        ' EditarActaMatrimonio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1119, 640)
        Controls.Add(MenuStrip1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(actaMatrimonioGBPadrinos)
        Controls.Add(actaMatrimonioAdministradorMatrimonio)
        Controls.Add(Label12)
        Controls.Add(Button2)
        Controls.Add(btnActaMatrimonioGenerar)
        Controls.Add(actaMatrimonioNombrePadrino)
        Controls.Add(actaMatrimonioNumeroActa)
        Controls.Add(actaMatrimonioNumeroLibro)
        Controls.Add(actaMatrimonioFechaExtension)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label4)
        Controls.Add(actaMatrimonioFechaMatrimonio)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EditarActaMatrimonio"
        Text = "Actualizar información de acta de matrimonio"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        actaMatrimonioGBPadresNovia.ResumeLayout(False)
        actaMatrimonioGBPadresNovia.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        actaMatrimonioGBPadresNovio.ResumeLayout(False)
        actaMatrimonioGBPadresNovio.PerformLayout()
        actaMatrimonioGBPadrinos.ResumeLayout(False)
        actaMatrimonioGBPadrinos.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActasDeConfirmaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeDeBautismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActaDeMatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents actaMatrimonioGBPadresNovia As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents actaMatrimonioEdadNovia As TextBox
    Friend WithEvents actaMatrimonioNombreNovia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents actaMatrimonioDepartamentoNovia As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents actaMatrimonioNombreMadreNovia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents actaMatrimonioNombrePadreNovia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents actaMatrimonioGBPadresNovio As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents actaMatrimonioEdadNovio As TextBox
    Friend WithEvents actaMatrimonioNombreNovio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents actaMatrimonioDepartamentoNovio As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents actaMatrimonioNombreMadreNovio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents actaMatrimonioNombrePadreNovio As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents actaMatrimonioGBPadrinos As GroupBox
    Friend WithEvents actaConfirmaMultiplesPadrinos As RadioButton
    Friend WithEvents actaConfirmaMadrina As RadioButton
    Friend WithEvents actaConfirmaPadrino As RadioButton
    Friend WithEvents actaMatrimonioAdministradorMatrimonio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnActaMatrimonioGenerar As Button
    Friend WithEvents actaMatrimonioNombrePadrino As TextBox
    Friend WithEvents actaMatrimonioNumeroActa As TextBox
    Friend WithEvents actaMatrimonioNumeroLibro As TextBox
    Friend WithEvents actaMatrimonioFechaExtension As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents actaMatrimonioFechaMatrimonio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
