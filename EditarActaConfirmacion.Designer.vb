<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarActaConfirmacion
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
        actaConfirmaGBGeneroConfirmado = New GroupBox()
        actaConfirmaFemenino = New RadioButton()
        actaConfirmaMasculino = New RadioButton()
        actaConfirmaGBPadrinos = New GroupBox()
        actaConfirmaMultiplesPadrinos = New RadioButton()
        actaConfirmaMadrina = New RadioButton()
        actaConfirmaPadrino = New RadioButton()
        actaConfirmaGBPadres = New GroupBox()
        actaConfirmaPadre = New RadioButton()
        actaConfirmaMadre = New RadioButton()
        actaConfirmaAmbosPadres = New RadioButton()
        actaConfirmaAdministradorSacramento = New TextBox()
        Label12 = New Label()
        Button2 = New Button()
        btnActaConfirmaGenerar = New Button()
        actaConfirmaDepartamentoNacimiento = New ComboBox()
        actaConfirmaNombrePadrino = New TextBox()
        actaConfirmaNombrePadre = New TextBox()
        actaConfirmaNombreMadre = New TextBox()
        actaConfirmaNombreConfirmado = New TextBox()
        actaConfirmaNumeroAsiento = New TextBox()
        actaConfirmaNumeroPagina = New TextBox()
        actaConfirmaNumeroLibro = New TextBox()
        actaConfirmaFechaNacimiento = New DateTimePicker()
        actaConfirmaFechaExtensión = New DateTimePicker()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        actaConfirmaSacramentoConfirma = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        ActasDeConfirmaciónToolStripMenuItem = New ToolStripMenuItem()
        FeDeBautismoToolStripMenuItem = New ToolStripMenuItem()
        ActaDeMatrimonioToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        BaseDeDatosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        actaConfirmaGBGeneroConfirmado.SuspendLayout()
        actaConfirmaGBPadrinos.SuspendLayout()
        actaConfirmaGBPadres.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' actaConfirmaGBGeneroConfirmado
        ' 
        actaConfirmaGBGeneroConfirmado.Controls.Add(actaConfirmaFemenino)
        actaConfirmaGBGeneroConfirmado.Controls.Add(actaConfirmaMasculino)
        actaConfirmaGBGeneroConfirmado.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaConfirmaGBGeneroConfirmado.Location = New Point(375, 209)
        actaConfirmaGBGeneroConfirmado.Name = "actaConfirmaGBGeneroConfirmado"
        actaConfirmaGBGeneroConfirmado.Size = New Size(328, 51)
        actaConfirmaGBGeneroConfirmado.TabIndex = 67
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
        ' actaConfirmaGBPadrinos
        ' 
        actaConfirmaGBPadrinos.Controls.Add(actaConfirmaMultiplesPadrinos)
        actaConfirmaGBPadrinos.Controls.Add(actaConfirmaMadrina)
        actaConfirmaGBPadrinos.Controls.Add(actaConfirmaPadrino)
        actaConfirmaGBPadrinos.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaConfirmaGBPadrinos.Location = New Point(375, 515)
        actaConfirmaGBPadrinos.Name = "actaConfirmaGBPadrinos"
        actaConfirmaGBPadrinos.Size = New Size(328, 51)
        actaConfirmaGBPadrinos.TabIndex = 66
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
        ' actaConfirmaGBPadres
        ' 
        actaConfirmaGBPadres.Controls.Add(actaConfirmaPadre)
        actaConfirmaGBPadres.Controls.Add(actaConfirmaMadre)
        actaConfirmaGBPadres.Controls.Add(actaConfirmaAmbosPadres)
        actaConfirmaGBPadres.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        actaConfirmaGBPadres.Location = New Point(375, 384)
        actaConfirmaGBPadres.Name = "actaConfirmaGBPadres"
        actaConfirmaGBPadres.Size = New Size(328, 51)
        actaConfirmaGBPadres.TabIndex = 65
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
        ' actaConfirmaAdministradorSacramento
        ' 
        actaConfirmaAdministradorSacramento.Location = New Point(408, 177)
        actaConfirmaAdministradorSacramento.Name = "actaConfirmaAdministradorSacramento"
        actaConfirmaAdministradorSacramento.PlaceholderText = "Administrador"
        actaConfirmaAdministradorSacramento.Size = New Size(264, 23)
        actaConfirmaAdministradorSacramento.TabIndex = 64
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(95, 186)
        Label12.Name = "Label12"
        Label12.Size = New Size(193, 19)
        Label12.TabIndex = 63
        Label12.Text = "Administrador del sacramento"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(599, 636)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 62
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnActaConfirmaGenerar
        ' 
        btnActaConfirmaGenerar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnActaConfirmaGenerar.Location = New Point(410, 636)
        btnActaConfirmaGenerar.Name = "btnActaConfirmaGenerar"
        btnActaConfirmaGenerar.Size = New Size(75, 36)
        btnActaConfirmaGenerar.TabIndex = 61
        btnActaConfirmaGenerar.Text = "Guardar"
        btnActaConfirmaGenerar.UseVisualStyleBackColor = True
        ' 
        ' actaConfirmaDepartamentoNacimiento
        ' 
        actaConfirmaDepartamentoNacimiento.DisplayMember = "gg"
        actaConfirmaDepartamentoNacimiento.DropDownStyle = ComboBoxStyle.DropDownList
        actaConfirmaDepartamentoNacimiento.FormattingEnabled = True
        actaConfirmaDepartamentoNacimiento.Location = New Point(408, 304)
        actaConfirmaDepartamentoNacimiento.Name = "actaConfirmaDepartamentoNacimiento"
        actaConfirmaDepartamentoNacimiento.Size = New Size(264, 23)
        actaConfirmaDepartamentoNacimiento.TabIndex = 60
        ' 
        ' actaConfirmaNombrePadrino
        ' 
        actaConfirmaNombrePadrino.Location = New Point(410, 573)
        actaConfirmaNombrePadrino.Name = "actaConfirmaNombrePadrino"
        actaConfirmaNombrePadrino.PlaceholderText = "Nombre de padrin@/s"
        actaConfirmaNombrePadrino.Size = New Size(264, 23)
        actaConfirmaNombrePadrino.TabIndex = 59
        ' 
        ' actaConfirmaNombrePadre
        ' 
        actaConfirmaNombrePadre.Location = New Point(408, 475)
        actaConfirmaNombrePadre.Name = "actaConfirmaNombrePadre"
        actaConfirmaNombrePadre.PlaceholderText = "Padre de persona confirmada"
        actaConfirmaNombrePadre.Size = New Size(264, 23)
        actaConfirmaNombrePadre.TabIndex = 58
        ' 
        ' actaConfirmaNombreMadre
        ' 
        actaConfirmaNombreMadre.Location = New Point(408, 442)
        actaConfirmaNombreMadre.Name = "actaConfirmaNombreMadre"
        actaConfirmaNombreMadre.PlaceholderText = "Madre de persona confirmada"
        actaConfirmaNombreMadre.Size = New Size(264, 23)
        actaConfirmaNombreMadre.TabIndex = 57
        ' 
        ' actaConfirmaNombreConfirmado
        ' 
        actaConfirmaNombreConfirmado.Location = New Point(408, 267)
        actaConfirmaNombreConfirmado.Name = "actaConfirmaNombreConfirmado"
        actaConfirmaNombreConfirmado.PlaceholderText = "Nombre de persona confirmada"
        actaConfirmaNombreConfirmado.Size = New Size(264, 23)
        actaConfirmaNombreConfirmado.TabIndex = 56
        ' 
        ' actaConfirmaNumeroAsiento
        ' 
        actaConfirmaNumeroAsiento.Location = New Point(408, 104)
        actaConfirmaNumeroAsiento.Name = "actaConfirmaNumeroAsiento"
        actaConfirmaNumeroAsiento.PlaceholderText = "Asiento"
        actaConfirmaNumeroAsiento.Size = New Size(264, 23)
        actaConfirmaNumeroAsiento.TabIndex = 55
        ' 
        ' actaConfirmaNumeroPagina
        ' 
        actaConfirmaNumeroPagina.Location = New Point(408, 71)
        actaConfirmaNumeroPagina.Name = "actaConfirmaNumeroPagina"
        actaConfirmaNumeroPagina.PlaceholderText = "Página"
        actaConfirmaNumeroPagina.Size = New Size(264, 23)
        actaConfirmaNumeroPagina.TabIndex = 54
        ' 
        ' actaConfirmaNumeroLibro
        ' 
        actaConfirmaNumeroLibro.Location = New Point(408, 38)
        actaConfirmaNumeroLibro.Name = "actaConfirmaNumeroLibro"
        actaConfirmaNumeroLibro.PlaceholderText = "Libro"
        actaConfirmaNumeroLibro.Size = New Size(264, 23)
        actaConfirmaNumeroLibro.TabIndex = 53
        ' 
        ' actaConfirmaFechaNacimiento
        ' 
        actaConfirmaFechaNacimiento.Location = New Point(408, 336)
        actaConfirmaFechaNacimiento.Name = "actaConfirmaFechaNacimiento"
        actaConfirmaFechaNacimiento.Size = New Size(264, 23)
        actaConfirmaFechaNacimiento.TabIndex = 52
        ' 
        ' actaConfirmaFechaExtensión
        ' 
        actaConfirmaFechaExtensión.Location = New Point(410, 603)
        actaConfirmaFechaExtensión.Name = "actaConfirmaFechaExtensión"
        actaConfirmaFechaExtensión.Size = New Size(264, 23)
        actaConfirmaFechaExtensión.TabIndex = 51
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(95, 342)
        Label11.Name = "Label11"
        Label11.Size = New Size(134, 19)
        Label11.TabIndex = 50
        Label11.Text = "Fecha de nacimiento"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(97, 612)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 19)
        Label10.TabIndex = 49
        Label10.Text = "Fecha de extensión"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(97, 579)
        Label9.Name = "Label9"
        Label9.Size = New Size(245, 19)
        Label9.TabIndex = 48
        Label9.Text = "Nombre del padrino/madrina/padrinos"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(95, 442)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 19)
        Label8.TabIndex = 47
        Label8.Text = "Nombre de la madre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(95, 475)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 19)
        Label7.TabIndex = 46
        Label7.Text = "Nombre del padre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(95, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 19)
        Label6.TabIndex = 45
        Label6.Text = "Departamento de nacimiento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(95, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 19)
        Label5.TabIndex = 44
        Label5.Text = "Nombre completo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(95, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 19)
        Label4.TabIndex = 43
        Label4.Text = "Sacramento de confirmación"
        ' 
        ' actaConfirmaSacramentoConfirma
        ' 
        actaConfirmaSacramentoConfirma.Location = New Point(408, 138)
        actaConfirmaSacramentoConfirma.Name = "actaConfirmaSacramentoConfirma"
        actaConfirmaSacramentoConfirma.Size = New Size(264, 23)
        actaConfirmaSacramentoConfirma.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(95, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 19)
        Label3.TabIndex = 41
        Label3.Text = "Asiento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(95, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 19)
        Label2.TabIndex = 40
        Label2.Text = "Página"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(95, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 19)
        Label1.TabIndex = 39
        Label1.Text = "Libro"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ConfiguraciónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 38
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
        ' EditarActaConfirmacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 688)
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
        Name = "EditarActaConfirmacion"
        Text = "Actualizar información de confirmación"
        actaConfirmaGBGeneroConfirmado.ResumeLayout(False)
        actaConfirmaGBGeneroConfirmado.PerformLayout()
        actaConfirmaGBPadrinos.ResumeLayout(False)
        actaConfirmaGBPadrinos.PerformLayout()
        actaConfirmaGBPadres.ResumeLayout(False)
        actaConfirmaGBPadres.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents actaConfirmaGBGeneroConfirmado As GroupBox
    Friend WithEvents actaConfirmaFemenino As RadioButton
    Friend WithEvents actaConfirmaMasculino As RadioButton
    Friend WithEvents actaConfirmaGBPadrinos As GroupBox
    Friend WithEvents actaConfirmaMultiplesPadrinos As RadioButton
    Friend WithEvents actaConfirmaMadrina As RadioButton
    Friend WithEvents actaConfirmaPadrino As RadioButton
    Friend WithEvents actaConfirmaGBPadres As GroupBox
    Friend WithEvents actaConfirmaPadre As RadioButton
    Friend WithEvents actaConfirmaMadre As RadioButton
    Friend WithEvents actaConfirmaAmbosPadres As RadioButton
    Friend WithEvents actaConfirmaAdministradorSacramento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnActaConfirmaGenerar As Button
    Friend WithEvents actaConfirmaDepartamentoNacimiento As ComboBox
    Friend WithEvents actaConfirmaNombrePadrino As TextBox
    Friend WithEvents actaConfirmaNombrePadre As TextBox
    Friend WithEvents actaConfirmaNombreMadre As TextBox
    Friend WithEvents actaConfirmaNombreConfirmado As TextBox
    Friend WithEvents actaConfirmaNumeroAsiento As TextBox
    Friend WithEvents actaConfirmaNumeroPagina As TextBox
    Friend WithEvents actaConfirmaNumeroLibro As TextBox
    Friend WithEvents actaConfirmaFechaNacimiento As DateTimePicker
    Friend WithEvents actaConfirmaFechaExtensión As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents actaConfirmaSacramentoConfirma As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActasDeConfirmaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeDeBautismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActaDeMatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
