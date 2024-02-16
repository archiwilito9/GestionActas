<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActaDeConfirmación
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ActaDeConfirmación))
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        ActasDeConfirmaciónToolStripMenuItem = New ToolStripMenuItem()
        FeDeBautismoToolStripMenuItem = New ToolStripMenuItem()
        ActaDeMatrimonioToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        BaseDeDatosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        actaConfirmaSacramentoConfirma = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        actaConfirmaFechaExtensión = New DateTimePicker()
        actaConfirmaFechaNacimiento = New DateTimePicker()
        actaConfirmaNumeroLibro = New TextBox()
        actaConfirmaNumeroPagina = New TextBox()
        actaConfirmaNumeroAsiento = New TextBox()
        actaConfirmaNombreConfirmado = New TextBox()
        actaConfirmaNombreMadre = New TextBox()
        actaConfirmaNombrePadre = New TextBox()
        actaConfirmaNombrePadrino = New TextBox()
        actaConfirmaDepartamentoNacimiento = New ComboBox()
        btnActaConfirmaGenerar = New Button()
        Button2 = New Button()
        actaConfirmaAdministradorSacramento = New TextBox()
        Label12 = New Label()
        actaConfirmaGBPadres = New GroupBox()
        actaConfirmaPadre = New RadioButton()
        actaConfirmaMadre = New RadioButton()
        actaConfirmaAmbosPadres = New RadioButton()
        actaConfirmaGBPadrinos = New GroupBox()
        actaConfirmaMultiplesPadrinos = New RadioButton()
        actaConfirmaMadrina = New RadioButton()
        actaConfirmaPadrino = New RadioButton()
        actaConfirmaGBGeneroConfirmado = New GroupBox()
        actaConfirmaFemenino = New RadioButton()
        actaConfirmaMasculino = New RadioButton()
        MenuStrip1.SuspendLayout()
        actaConfirmaGBPadres.SuspendLayout()
        actaConfirmaGBPadrinos.SuspendLayout()
        actaConfirmaGBGeneroConfirmado.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ConfiguraciónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(765, 24)
        MenuStrip1.TabIndex = 3
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
        ActasDeConfirmaciónToolStripMenuItem.Enabled = False
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(98, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 19)
        Label1.TabIndex = 4
        Label1.Text = "Libro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(98, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 19)
        Label2.TabIndex = 5
        Label2.Text = "Página"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(98, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 19)
        Label3.TabIndex = 6
        Label3.Text = "Asiento"
        ' 
        ' actaConfirmaSacramentoConfirma
        ' 
        actaConfirmaSacramentoConfirma.Location = New Point(411, 145)
        actaConfirmaSacramentoConfirma.Name = "actaConfirmaSacramentoConfirma"
        actaConfirmaSacramentoConfirma.Size = New Size(264, 25)
        actaConfirmaSacramentoConfirma.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(98, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 19)
        Label4.TabIndex = 8
        Label4.Text = "Sacramento de confirmación"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(98, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 19)
        Label5.TabIndex = 9
        Label5.Text = "Nombre completo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(98, 315)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 19)
        Label6.TabIndex = 10
        Label6.Text = "Departamento de nacimiento"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(98, 460)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 19)
        Label7.TabIndex = 11
        Label7.Text = "Nombre del padre"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(98, 491)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 19)
        Label8.TabIndex = 12
        Label8.Text = "Nombre de la madre"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(100, 586)
        Label9.Name = "Label9"
        Label9.Size = New Size(245, 19)
        Label9.TabIndex = 13
        Label9.Text = "Nombre del padrino/madrina/padrinos"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(100, 619)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 19)
        Label10.TabIndex = 14
        Label10.Text = "Fecha de extensión"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(98, 349)
        Label11.Name = "Label11"
        Label11.Size = New Size(134, 19)
        Label11.TabIndex = 15
        Label11.Text = "Fecha de nacimiento"
        ' 
        ' actaConfirmaFechaExtensión
        ' 
        actaConfirmaFechaExtensión.Location = New Point(413, 610)
        actaConfirmaFechaExtensión.Name = "actaConfirmaFechaExtensión"
        actaConfirmaFechaExtensión.Size = New Size(264, 25)
        actaConfirmaFechaExtensión.TabIndex = 16
        ' 
        ' actaConfirmaFechaNacimiento
        ' 
        actaConfirmaFechaNacimiento.Location = New Point(411, 343)
        actaConfirmaFechaNacimiento.Name = "actaConfirmaFechaNacimiento"
        actaConfirmaFechaNacimiento.Size = New Size(264, 25)
        actaConfirmaFechaNacimiento.TabIndex = 17
        ' 
        ' actaConfirmaNumeroLibro
        ' 
        actaConfirmaNumeroLibro.Location = New Point(411, 45)
        actaConfirmaNumeroLibro.Name = "actaConfirmaNumeroLibro"
        actaConfirmaNumeroLibro.PlaceholderText = "Libro"
        actaConfirmaNumeroLibro.Size = New Size(264, 25)
        actaConfirmaNumeroLibro.TabIndex = 18
        ' 
        ' actaConfirmaNumeroPagina
        ' 
        actaConfirmaNumeroPagina.Location = New Point(411, 78)
        actaConfirmaNumeroPagina.Name = "actaConfirmaNumeroPagina"
        actaConfirmaNumeroPagina.PlaceholderText = "Página"
        actaConfirmaNumeroPagina.Size = New Size(264, 25)
        actaConfirmaNumeroPagina.TabIndex = 19
        ' 
        ' actaConfirmaNumeroAsiento
        ' 
        actaConfirmaNumeroAsiento.Location = New Point(411, 111)
        actaConfirmaNumeroAsiento.Name = "actaConfirmaNumeroAsiento"
        actaConfirmaNumeroAsiento.PlaceholderText = "Asiento"
        actaConfirmaNumeroAsiento.Size = New Size(264, 25)
        actaConfirmaNumeroAsiento.TabIndex = 20
        ' 
        ' actaConfirmaNombreConfirmado
        ' 
        actaConfirmaNombreConfirmado.Location = New Point(411, 274)
        actaConfirmaNombreConfirmado.Name = "actaConfirmaNombreConfirmado"
        actaConfirmaNombreConfirmado.PlaceholderText = "Nombre de persona confirmada"
        actaConfirmaNombreConfirmado.Size = New Size(264, 25)
        actaConfirmaNombreConfirmado.TabIndex = 21
        ' 
        ' actaConfirmaNombreMadre
        ' 
        actaConfirmaNombreMadre.Location = New Point(411, 491)
        actaConfirmaNombreMadre.Name = "actaConfirmaNombreMadre"
        actaConfirmaNombreMadre.PlaceholderText = "Madre de persona confirmada"
        actaConfirmaNombreMadre.Size = New Size(264, 25)
        actaConfirmaNombreMadre.TabIndex = 22
        ' 
        ' actaConfirmaNombrePadre
        ' 
        actaConfirmaNombrePadre.Location = New Point(411, 460)
        actaConfirmaNombrePadre.Name = "actaConfirmaNombrePadre"
        actaConfirmaNombrePadre.PlaceholderText = "Padre de persona confirmada"
        actaConfirmaNombrePadre.Size = New Size(264, 25)
        actaConfirmaNombrePadre.TabIndex = 23
        ' 
        ' actaConfirmaNombrePadrino
        ' 
        actaConfirmaNombrePadrino.Location = New Point(413, 580)
        actaConfirmaNombrePadrino.Name = "actaConfirmaNombrePadrino"
        actaConfirmaNombrePadrino.PlaceholderText = "Nombre de padrin@/s"
        actaConfirmaNombrePadrino.Size = New Size(264, 25)
        actaConfirmaNombrePadrino.TabIndex = 24
        ' 
        ' actaConfirmaDepartamentoNacimiento
        ' 
        actaConfirmaDepartamentoNacimiento.DisplayMember = "gg"
        actaConfirmaDepartamentoNacimiento.DropDownStyle = ComboBoxStyle.DropDownList
        actaConfirmaDepartamentoNacimiento.FormattingEnabled = True
        actaConfirmaDepartamentoNacimiento.Location = New Point(411, 311)
        actaConfirmaDepartamentoNacimiento.Name = "actaConfirmaDepartamentoNacimiento"
        actaConfirmaDepartamentoNacimiento.Size = New Size(264, 25)
        actaConfirmaDepartamentoNacimiento.TabIndex = 25
        ' 
        ' btnActaConfirmaGenerar
        ' 
        btnActaConfirmaGenerar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnActaConfirmaGenerar.Location = New Point(413, 643)
        btnActaConfirmaGenerar.Name = "btnActaConfirmaGenerar"
        btnActaConfirmaGenerar.Size = New Size(75, 36)
        btnActaConfirmaGenerar.TabIndex = 26
        btnActaConfirmaGenerar.Text = "Ingresar"
        btnActaConfirmaGenerar.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(602, 643)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 27
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaAdministradorSacramento
        ' 
        actaConfirmaAdministradorSacramento.Location = New Point(411, 184)
        actaConfirmaAdministradorSacramento.Name = "actaConfirmaAdministradorSacramento"
        actaConfirmaAdministradorSacramento.PlaceholderText = "Administrador"
        actaConfirmaAdministradorSacramento.Size = New Size(264, 25)
        actaConfirmaAdministradorSacramento.TabIndex = 35
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(98, 193)
        Label12.Name = "Label12"
        Label12.Size = New Size(193, 19)
        Label12.TabIndex = 34
        Label12.Text = "Administrador del sacramento"
        ' 
        ' actaConfirmaGBPadres
        ' 
        actaConfirmaGBPadres.Controls.Add(actaConfirmaPadre)
        actaConfirmaGBPadres.Controls.Add(actaConfirmaMadre)
        actaConfirmaGBPadres.Controls.Add(actaConfirmaAmbosPadres)
        actaConfirmaGBPadres.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaConfirmaGBPadres.Location = New Point(378, 391)
        actaConfirmaGBPadres.Name = "actaConfirmaGBPadres"
        actaConfirmaGBPadres.Size = New Size(328, 51)
        actaConfirmaGBPadres.TabIndex = 36
        actaConfirmaGBPadres.TabStop = False
        actaConfirmaGBPadres.Text = "Padres de persona confirmada"
        ' 
        ' actaConfirmaPadre
        ' 
        actaConfirmaPadre.AutoSize = True
        actaConfirmaPadre.Location = New Point(230, 18)
        actaConfirmaPadre.Name = "actaConfirmaPadre"
        actaConfirmaPadre.Size = New Size(92, 23)
        actaConfirmaPadre.TabIndex = 2
        actaConfirmaPadre.Text = "Solo padre"
        actaConfirmaPadre.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaMadre
        ' 
        actaConfirmaMadre.AutoSize = True
        actaConfirmaMadre.Location = New Point(128, 18)
        actaConfirmaMadre.Name = "actaConfirmaMadre"
        actaConfirmaMadre.Size = New Size(96, 23)
        actaConfirmaMadre.TabIndex = 1
        actaConfirmaMadre.Text = "Solo madre"
        actaConfirmaMadre.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaAmbosPadres
        ' 
        actaConfirmaAmbosPadres.AutoSize = True
        actaConfirmaAmbosPadres.Checked = True
        actaConfirmaAmbosPadres.Location = New Point(7, 18)
        actaConfirmaAmbosPadres.Name = "actaConfirmaAmbosPadres"
        actaConfirmaAmbosPadres.Size = New Size(115, 23)
        actaConfirmaAmbosPadres.TabIndex = 0
        actaConfirmaAmbosPadres.TabStop = True
        actaConfirmaAmbosPadres.Text = "Ambos padres"
        actaConfirmaAmbosPadres.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaGBPadrinos
        ' 
        actaConfirmaGBPadrinos.Controls.Add(actaConfirmaMultiplesPadrinos)
        actaConfirmaGBPadrinos.Controls.Add(actaConfirmaMadrina)
        actaConfirmaGBPadrinos.Controls.Add(actaConfirmaPadrino)
        actaConfirmaGBPadrinos.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaConfirmaGBPadrinos.Location = New Point(378, 522)
        actaConfirmaGBPadrinos.Name = "actaConfirmaGBPadrinos"
        actaConfirmaGBPadrinos.Size = New Size(328, 51)
        actaConfirmaGBPadrinos.TabIndex = 37
        actaConfirmaGBPadrinos.TabStop = False
        actaConfirmaGBPadrinos.Text = "Padrinos de persona confirmada"
        ' 
        ' actaConfirmaMultiplesPadrinos
        ' 
        actaConfirmaMultiplesPadrinos.AutoSize = True
        actaConfirmaMultiplesPadrinos.Location = New Point(168, 23)
        actaConfirmaMultiplesPadrinos.Name = "actaConfirmaMultiplesPadrinos"
        actaConfirmaMultiplesPadrinos.Size = New Size(140, 23)
        actaConfirmaMultiplesPadrinos.TabIndex = 5
        actaConfirmaMultiplesPadrinos.Text = "Múltiples padrinos"
        actaConfirmaMultiplesPadrinos.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaMadrina
        ' 
        actaConfirmaMadrina.AutoSize = True
        actaConfirmaMadrina.Location = New Point(90, 23)
        actaConfirmaMadrina.Name = "actaConfirmaMadrina"
        actaConfirmaMadrina.Size = New Size(78, 23)
        actaConfirmaMadrina.TabIndex = 4
        actaConfirmaMadrina.Text = "Madrina"
        actaConfirmaMadrina.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaPadrino
        ' 
        actaConfirmaPadrino.AutoSize = True
        actaConfirmaPadrino.Checked = True
        actaConfirmaPadrino.Location = New Point(13, 23)
        actaConfirmaPadrino.Name = "actaConfirmaPadrino"
        actaConfirmaPadrino.Size = New Size(74, 23)
        actaConfirmaPadrino.TabIndex = 3
        actaConfirmaPadrino.TabStop = True
        actaConfirmaPadrino.Text = "Padrino"
        actaConfirmaPadrino.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaGBGeneroConfirmado
        ' 
        actaConfirmaGBGeneroConfirmado.Controls.Add(actaConfirmaFemenino)
        actaConfirmaGBGeneroConfirmado.Controls.Add(actaConfirmaMasculino)
        actaConfirmaGBGeneroConfirmado.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaConfirmaGBGeneroConfirmado.Location = New Point(378, 216)
        actaConfirmaGBGeneroConfirmado.Name = "actaConfirmaGBGeneroConfirmado"
        actaConfirmaGBGeneroConfirmado.Size = New Size(328, 51)
        actaConfirmaGBGeneroConfirmado.TabIndex = 37
        actaConfirmaGBGeneroConfirmado.TabStop = False
        actaConfirmaGBGeneroConfirmado.Text = "Género de persona confirmada"
        ' 
        ' actaConfirmaFemenino
        ' 
        actaConfirmaFemenino.AutoSize = True
        actaConfirmaFemenino.Location = New Point(185, 19)
        actaConfirmaFemenino.Name = "actaConfirmaFemenino"
        actaConfirmaFemenino.Size = New Size(87, 23)
        actaConfirmaFemenino.TabIndex = 2
        actaConfirmaFemenino.Text = "Femenino"
        actaConfirmaFemenino.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaMasculino
        ' 
        actaConfirmaMasculino.AutoSize = True
        actaConfirmaMasculino.Checked = True
        actaConfirmaMasculino.Location = New Point(49, 19)
        actaConfirmaMasculino.Name = "actaConfirmaMasculino"
        actaConfirmaMasculino.Size = New Size(89, 23)
        actaConfirmaMasculino.TabIndex = 1
        actaConfirmaMasculino.TabStop = True
        actaConfirmaMasculino.Text = "Masculino"
        actaConfirmaMasculino.UseVisualStyleBackColor = True
        ' 
        ' ActaDeConfirmación
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(765, 697)
        Controls.Add(actaConfirmaGBGeneroConfirmado)
        Controls.Add(actaConfirmaGBPadrinos)
        Controls.Add(actaConfirmaGBPadres)
        Controls.Add(actaConfirmaAdministradorSacramento)
        Controls.Add(Label12)
        Controls.Add(Button2)
        Controls.Add(btnActaConfirmaGenerar)
        Controls.Add(actaConfirmaDepartamentoNacimiento)
        Controls.Add(actaConfirmaNombrePadrino)
        Controls.Add(actaConfirmaNombrePadre)
        Controls.Add(actaConfirmaNombreMadre)
        Controls.Add(actaConfirmaNombreConfirmado)
        Controls.Add(actaConfirmaNumeroAsiento)
        Controls.Add(actaConfirmaNumeroPagina)
        Controls.Add(actaConfirmaNumeroLibro)
        Controls.Add(actaConfirmaFechaNacimiento)
        Controls.Add(actaConfirmaFechaExtensión)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(actaConfirmaSacramentoConfirma)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ActaDeConfirmación"
        Text = "Acta de confirmación"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        actaConfirmaGBPadres.ResumeLayout(False)
        actaConfirmaGBPadres.PerformLayout()
        actaConfirmaGBPadrinos.ResumeLayout(False)
        actaConfirmaGBPadrinos.PerformLayout()
        actaConfirmaGBGeneroConfirmado.ResumeLayout(False)
        actaConfirmaGBGeneroConfirmado.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActasDeConfirmaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeDeBautismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActaDeMatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents actaConfirmaSacramentoConfirma As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents actaConfirmaFechaExtensión As DateTimePicker
    Friend WithEvents actaConfirmaFechaNacimiento As DateTimePicker
    Friend WithEvents actaConfirmaNumeroLibro As TextBox
    Friend WithEvents actaConfirmaNumeroPagina As TextBox
    Friend WithEvents actaConfirmaNumeroAsiento As TextBox
    Friend WithEvents actaConfirmaNombreConfirmado As TextBox
    Friend WithEvents actaConfirmaNombreMadre As TextBox
    Friend WithEvents actaConfirmaNombrePadre As TextBox
    Friend WithEvents actaConfirmaNombrePadrino As TextBox
    Friend WithEvents actaConfirmaDepartamentoNacimiento As ComboBox
    Friend WithEvents btnActaConfirmaGenerar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents actaConfirmaAdministradorSacramento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents actaConfirmaGBPadres As GroupBox
    Friend WithEvents actaConfirmaGBPadrinos As GroupBox
    Friend WithEvents actaConfirmaPadre As RadioButton
    Friend WithEvents actaConfirmaMadre As RadioButton
    Friend WithEvents actaConfirmaAmbosPadres As RadioButton
    Friend WithEvents actaConfirmaMultiplesPadrinos As RadioButton
    Friend WithEvents actaConfirmaMadrina As RadioButton
    Friend WithEvents actaConfirmaPadrino As RadioButton
    Friend WithEvents actaConfirmaGBGeneroConfirmado As GroupBox
    Friend WithEvents actaConfirmaFemenino As RadioButton
    Friend WithEvents actaConfirmaMasculino As RadioButton
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
End Class
