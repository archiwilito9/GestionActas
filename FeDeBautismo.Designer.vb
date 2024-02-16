<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeDeBautismo
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FeDeBautismo))
        feBautismoGBGeneroConfirmado = New GroupBox()
        feBautismoFemenino = New RadioButton()
        feBautismoMasculino = New RadioButton()
        feBautismoGBPadrinos = New GroupBox()
        feBautismoMultiplesPadrinos = New RadioButton()
        feBautismoMadrina = New RadioButton()
        feBautismoPadrino = New RadioButton()
        feBautismoGBPadres = New GroupBox()
        feBautismoPadre = New RadioButton()
        feBautismoMadre = New RadioButton()
        feBautismoAmbosPadres = New RadioButton()
        feBautismoAdministradorSacramento = New TextBox()
        Label12 = New Label()
        Button2 = New Button()
        btnFeBautismoGenerar = New Button()
        feBautismoDepartamentoNacimiento = New ComboBox()
        feBautismoNombrePadrino = New TextBox()
        feBautismoNombrePadre = New TextBox()
        feBautismoNombreMadre = New TextBox()
        feBautismoNombreConfirmado = New TextBox()
        feBautismoNumeroAsiento = New TextBox()
        feBautismoNumeroPagina = New TextBox()
        feBautismoNumeroLibro = New TextBox()
        feBautismoFechaNacimiento = New DateTimePicker()
        feBautismoFechaExtensión = New DateTimePicker()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        feBautismoSacramentoConfirma = New DateTimePicker()
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
        feBautismoGBGeneroConfirmado.SuspendLayout()
        feBautismoGBPadrinos.SuspendLayout()
        feBautismoGBPadres.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' feBautismoGBGeneroConfirmado
        ' 
        feBautismoGBGeneroConfirmado.Controls.Add(feBautismoFemenino)
        feBautismoGBGeneroConfirmado.Controls.Add(feBautismoMasculino)
        feBautismoGBGeneroConfirmado.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        feBautismoGBGeneroConfirmado.Location = New Point(402, 214)
        feBautismoGBGeneroConfirmado.Name = "feBautismoGBGeneroConfirmado"
        feBautismoGBGeneroConfirmado.Size = New Size(314, 51)
        feBautismoGBGeneroConfirmado.TabIndex = 67
        feBautismoGBGeneroConfirmado.TabStop = False
        feBautismoGBGeneroConfirmado.Text = "Género de persona bautizada"
        ' 
        ' feBautismoFemenino
        ' 
        feBautismoFemenino.AutoSize = True
        feBautismoFemenino.Location = New Point(185, 19)
        feBautismoFemenino.Name = "feBautismoFemenino"
        feBautismoFemenino.Size = New Size(87, 23)
        feBautismoFemenino.TabIndex = 2
        feBautismoFemenino.Text = "Femenino"
        feBautismoFemenino.UseVisualStyleBackColor = True
        ' 
        ' feBautismoMasculino
        ' 
        feBautismoMasculino.AutoSize = True
        feBautismoMasculino.Checked = True
        feBautismoMasculino.Location = New Point(49, 19)
        feBautismoMasculino.Name = "feBautismoMasculino"
        feBautismoMasculino.Size = New Size(89, 23)
        feBautismoMasculino.TabIndex = 1
        feBautismoMasculino.TabStop = True
        feBautismoMasculino.Text = "Masculino"
        feBautismoMasculino.UseVisualStyleBackColor = True
        ' 
        ' feBautismoGBPadrinos
        ' 
        feBautismoGBPadrinos.Controls.Add(feBautismoMultiplesPadrinos)
        feBautismoGBPadrinos.Controls.Add(feBautismoMadrina)
        feBautismoGBPadrinos.Controls.Add(feBautismoPadrino)
        feBautismoGBPadrinos.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        feBautismoGBPadrinos.Location = New Point(402, 520)
        feBautismoGBPadrinos.Name = "feBautismoGBPadrinos"
        feBautismoGBPadrinos.Size = New Size(314, 51)
        feBautismoGBPadrinos.TabIndex = 66
        feBautismoGBPadrinos.TabStop = False
        feBautismoGBPadrinos.Text = "Padrinos de persona bautizada"
        ' 
        ' feBautismoMultiplesPadrinos
        ' 
        feBautismoMultiplesPadrinos.AutoSize = True
        feBautismoMultiplesPadrinos.Location = New Point(168, 23)
        feBautismoMultiplesPadrinos.Name = "feBautismoMultiplesPadrinos"
        feBautismoMultiplesPadrinos.Size = New Size(140, 23)
        feBautismoMultiplesPadrinos.TabIndex = 5
        feBautismoMultiplesPadrinos.Text = "Múltiples padrinos"
        feBautismoMultiplesPadrinos.UseVisualStyleBackColor = True
        ' 
        ' feBautismoMadrina
        ' 
        feBautismoMadrina.AutoSize = True
        feBautismoMadrina.Location = New Point(90, 23)
        feBautismoMadrina.Name = "feBautismoMadrina"
        feBautismoMadrina.Size = New Size(78, 23)
        feBautismoMadrina.TabIndex = 4
        feBautismoMadrina.Text = "Madrina"
        feBautismoMadrina.UseVisualStyleBackColor = True
        ' 
        ' feBautismoPadrino
        ' 
        feBautismoPadrino.AutoSize = True
        feBautismoPadrino.Checked = True
        feBautismoPadrino.Location = New Point(13, 23)
        feBautismoPadrino.Name = "feBautismoPadrino"
        feBautismoPadrino.Size = New Size(74, 23)
        feBautismoPadrino.TabIndex = 3
        feBautismoPadrino.TabStop = True
        feBautismoPadrino.Text = "Padrino"
        feBautismoPadrino.UseVisualStyleBackColor = True
        ' 
        ' feBautismoGBPadres
        ' 
        feBautismoGBPadres.Controls.Add(feBautismoPadre)
        feBautismoGBPadres.Controls.Add(feBautismoMadre)
        feBautismoGBPadres.Controls.Add(feBautismoAmbosPadres)
        feBautismoGBPadres.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        feBautismoGBPadres.Location = New Point(402, 389)
        feBautismoGBPadres.Name = "feBautismoGBPadres"
        feBautismoGBPadres.Size = New Size(314, 51)
        feBautismoGBPadres.TabIndex = 65
        feBautismoGBPadres.TabStop = False
        feBautismoGBPadres.Text = "Padres de persona bautizada"
        ' 
        ' feBautismoPadre
        ' 
        feBautismoPadre.AutoSize = True
        feBautismoPadre.Location = New Point(216, 19)
        feBautismoPadre.Name = "feBautismoPadre"
        feBautismoPadre.Size = New Size(92, 23)
        feBautismoPadre.TabIndex = 2
        feBautismoPadre.Text = "Solo padre"
        feBautismoPadre.UseVisualStyleBackColor = True
        ' 
        ' feBautismoMadre
        ' 
        feBautismoMadre.AutoSize = True
        feBautismoMadre.Location = New Point(120, 19)
        feBautismoMadre.Name = "feBautismoMadre"
        feBautismoMadre.Size = New Size(96, 23)
        feBautismoMadre.TabIndex = 1
        feBautismoMadre.Text = "Solo madre"
        feBautismoMadre.UseVisualStyleBackColor = True
        ' 
        ' feBautismoAmbosPadres
        ' 
        feBautismoAmbosPadres.AutoSize = True
        feBautismoAmbosPadres.Checked = True
        feBautismoAmbosPadres.Location = New Point(9, 19)
        feBautismoAmbosPadres.Name = "feBautismoAmbosPadres"
        feBautismoAmbosPadres.Size = New Size(115, 23)
        feBautismoAmbosPadres.TabIndex = 0
        feBautismoAmbosPadres.TabStop = True
        feBautismoAmbosPadres.Text = "Ambos padres"
        feBautismoAmbosPadres.UseVisualStyleBackColor = True
        ' 
        ' feBautismoAdministradorSacramento
        ' 
        feBautismoAdministradorSacramento.Location = New Point(435, 181)
        feBautismoAdministradorSacramento.Name = "feBautismoAdministradorSacramento"
        feBautismoAdministradorSacramento.PlaceholderText = "Administrador del bautizo"
        feBautismoAdministradorSacramento.Size = New Size(264, 25)
        feBautismoAdministradorSacramento.TabIndex = 64
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(122, 190)
        Label12.Name = "Label12"
        Label12.Size = New Size(167, 19)
        Label12.TabIndex = 63
        Label12.Text = "Administrador del bautizo"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(626, 640)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 62
        Button2.Text = "Regresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnFeBautismoGenerar
        ' 
        btnFeBautismoGenerar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        btnFeBautismoGenerar.Location = New Point(437, 640)
        btnFeBautismoGenerar.Name = "btnFeBautismoGenerar"
        btnFeBautismoGenerar.Size = New Size(75, 36)
        btnFeBautismoGenerar.TabIndex = 61
        btnFeBautismoGenerar.Text = "Ingresar"
        btnFeBautismoGenerar.UseVisualStyleBackColor = True
        ' 
        ' feBautismoDepartamentoNacimiento
        ' 
        feBautismoDepartamentoNacimiento.DisplayMember = "gg"
        feBautismoDepartamentoNacimiento.DropDownStyle = ComboBoxStyle.DropDownList
        feBautismoDepartamentoNacimiento.FormattingEnabled = True
        feBautismoDepartamentoNacimiento.Location = New Point(435, 308)
        feBautismoDepartamentoNacimiento.Name = "feBautismoDepartamentoNacimiento"
        feBautismoDepartamentoNacimiento.Size = New Size(264, 25)
        feBautismoDepartamentoNacimiento.TabIndex = 60
        ' 
        ' feBautismoNombrePadrino
        ' 
        feBautismoNombrePadrino.Location = New Point(437, 578)
        feBautismoNombrePadrino.Name = "feBautismoNombrePadrino"
        feBautismoNombrePadrino.PlaceholderText = "Nombre de padrin@/s"
        feBautismoNombrePadrino.Size = New Size(264, 25)
        feBautismoNombrePadrino.TabIndex = 59
        ' 
        ' feBautismoNombrePadre
        ' 
        feBautismoNombrePadre.Location = New Point(435, 458)
        feBautismoNombrePadre.Name = "feBautismoNombrePadre"
        feBautismoNombrePadre.PlaceholderText = "Padre de persona bautizada"
        feBautismoNombrePadre.Size = New Size(264, 25)
        feBautismoNombrePadre.TabIndex = 58
        ' 
        ' feBautismoNombreMadre
        ' 
        feBautismoNombreMadre.Location = New Point(435, 489)
        feBautismoNombreMadre.Name = "feBautismoNombreMadre"
        feBautismoNombreMadre.PlaceholderText = "Madre de persona bautizada"
        feBautismoNombreMadre.Size = New Size(264, 25)
        feBautismoNombreMadre.TabIndex = 57
        ' 
        ' feBautismoNombreConfirmado
        ' 
        feBautismoNombreConfirmado.Location = New Point(435, 272)
        feBautismoNombreConfirmado.Name = "feBautismoNombreConfirmado"
        feBautismoNombreConfirmado.PlaceholderText = "Nombre de persona bautizada"
        feBautismoNombreConfirmado.Size = New Size(264, 25)
        feBautismoNombreConfirmado.TabIndex = 56
        ' 
        ' feBautismoNumeroAsiento
        ' 
        feBautismoNumeroAsiento.Location = New Point(435, 109)
        feBautismoNumeroAsiento.Name = "feBautismoNumeroAsiento"
        feBautismoNumeroAsiento.PlaceholderText = "Asiento"
        feBautismoNumeroAsiento.Size = New Size(264, 25)
        feBautismoNumeroAsiento.TabIndex = 55
        ' 
        ' feBautismoNumeroPagina
        ' 
        feBautismoNumeroPagina.Location = New Point(435, 76)
        feBautismoNumeroPagina.Name = "feBautismoNumeroPagina"
        feBautismoNumeroPagina.PlaceholderText = "Página"
        feBautismoNumeroPagina.Size = New Size(264, 25)
        feBautismoNumeroPagina.TabIndex = 54
        ' 
        ' feBautismoNumeroLibro
        ' 
        feBautismoNumeroLibro.Location = New Point(435, 43)
        feBautismoNumeroLibro.Name = "feBautismoNumeroLibro"
        feBautismoNumeroLibro.PlaceholderText = "Libro"
        feBautismoNumeroLibro.Size = New Size(264, 25)
        feBautismoNumeroLibro.TabIndex = 53
        feBautismoNumeroLibro.Tag = ""
        ' 
        ' feBautismoFechaNacimiento
        ' 
        feBautismoFechaNacimiento.Location = New Point(435, 341)
        feBautismoFechaNacimiento.Name = "feBautismoFechaNacimiento"
        feBautismoFechaNacimiento.Size = New Size(264, 25)
        feBautismoFechaNacimiento.TabIndex = 52
        ' 
        ' feBautismoFechaExtensión
        ' 
        feBautismoFechaExtensión.Location = New Point(437, 607)
        feBautismoFechaExtensión.Name = "feBautismoFechaExtensión"
        feBautismoFechaExtensión.Size = New Size(264, 25)
        feBautismoFechaExtensión.TabIndex = 51
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(122, 347)
        Label11.Name = "Label11"
        Label11.Size = New Size(134, 19)
        Label11.TabIndex = 50
        Label11.Text = "Fecha de nacimiento"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(124, 617)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 19)
        Label10.TabIndex = 49
        Label10.Text = "Fecha de extensión"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(124, 584)
        Label9.Name = "Label9"
        Label9.Size = New Size(245, 19)
        Label9.TabIndex = 48
        Label9.Text = "Nombre del padrino/madrina/padrinos"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(122, 489)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 19)
        Label8.TabIndex = 47
        Label8.Text = "Nombre de la madre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(122, 458)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 19)
        Label7.TabIndex = 46
        Label7.Text = "Nombre del padre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(122, 313)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 19)
        Label6.TabIndex = 45
        Label6.Text = "Departamento de nacimiento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(122, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 19)
        Label5.TabIndex = 44
        Label5.Text = "Nombre completo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(122, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 19)
        Label4.TabIndex = 43
        Label4.Text = "Fecha de bautizo"
        ' 
        ' feBautismoSacramentoConfirma
        ' 
        feBautismoSacramentoConfirma.Location = New Point(435, 143)
        feBautismoSacramentoConfirma.Name = "feBautismoSacramentoConfirma"
        feBautismoSacramentoConfirma.Size = New Size(264, 25)
        feBautismoSacramentoConfirma.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(122, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 19)
        Label3.TabIndex = 41
        Label3.Text = "Asiento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(122, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 19)
        Label2.TabIndex = 40
        Label2.Text = "Página"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(122, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 19)
        Label1.TabIndex = 39
        Label1.Text = "Libro"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ConfiguraciónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(811, 27)
        MenuStrip1.TabIndex = 38
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActasDeConfirmaciónToolStripMenuItem, FeDeBautismoToolStripMenuItem, ActaDeMatrimonioToolStripMenuItem})
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(53, 23)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' ActasDeConfirmaciónToolStripMenuItem
        ' 
        ActasDeConfirmaciónToolStripMenuItem.Name = "ActasDeConfirmaciónToolStripMenuItem"
        ActasDeConfirmaciónToolStripMenuItem.Size = New Size(199, 24)
        ActasDeConfirmaciónToolStripMenuItem.Text = "Acta de confirma"
        ' 
        ' FeDeBautismoToolStripMenuItem
        ' 
        FeDeBautismoToolStripMenuItem.Enabled = False
        FeDeBautismoToolStripMenuItem.Name = "FeDeBautismoToolStripMenuItem"
        FeDeBautismoToolStripMenuItem.Size = New Size(199, 24)
        FeDeBautismoToolStripMenuItem.Text = "Fe de bautismo"
        ' 
        ' ActaDeMatrimonioToolStripMenuItem
        ' 
        ActaDeMatrimonioToolStripMenuItem.Name = "ActaDeMatrimonioToolStripMenuItem"
        ActaDeMatrimonioToolStripMenuItem.Size = New Size(199, 24)
        ActaDeMatrimonioToolStripMenuItem.Text = "Acta de matrimonio"
        ' 
        ' ConfiguraciónToolStripMenuItem
        ' 
        ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BaseDeDatosToolStripMenuItem})
        ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        ConfiguraciónToolStripMenuItem.Size = New Size(106, 23)
        ConfiguraciónToolStripMenuItem.Text = "Configuración"
        ' 
        ' BaseDeDatosToolStripMenuItem
        ' 
        BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        BaseDeDatosToolStripMenuItem.Size = New Size(163, 24)
        BaseDeDatosToolStripMenuItem.Text = "Base de datos"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(46, 23)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' FeDeBautismo
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(811, 696)
        Controls.Add(feBautismoGBGeneroConfirmado)
        Controls.Add(feBautismoGBPadrinos)
        Controls.Add(feBautismoGBPadres)
        Controls.Add(feBautismoAdministradorSacramento)
        Controls.Add(Label12)
        Controls.Add(Button2)
        Controls.Add(btnFeBautismoGenerar)
        Controls.Add(feBautismoDepartamentoNacimiento)
        Controls.Add(feBautismoNombrePadrino)
        Controls.Add(feBautismoNombrePadre)
        Controls.Add(feBautismoNombreMadre)
        Controls.Add(feBautismoNombreConfirmado)
        Controls.Add(feBautismoNumeroAsiento)
        Controls.Add(feBautismoNumeroPagina)
        Controls.Add(feBautismoNumeroLibro)
        Controls.Add(feBautismoFechaNacimiento)
        Controls.Add(feBautismoFechaExtensión)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(feBautismoSacramentoConfirma)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FeDeBautismo"
        Text = "Fe de bautismo"
        feBautismoGBGeneroConfirmado.ResumeLayout(False)
        feBautismoGBGeneroConfirmado.PerformLayout()
        feBautismoGBPadrinos.ResumeLayout(False)
        feBautismoGBPadrinos.PerformLayout()
        feBautismoGBPadres.ResumeLayout(False)
        feBautismoGBPadres.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents feBautismoGBGeneroConfirmado As GroupBox
    Friend WithEvents feBautismoFemenino As RadioButton
    Friend WithEvents feBautismoMasculino As RadioButton
    Friend WithEvents feBautismoGBPadrinos As GroupBox
    Friend WithEvents feBautismoMultiplesPadrinos As RadioButton
    Friend WithEvents feBautismoMadrina As RadioButton
    Friend WithEvents feBautismoPadrino As RadioButton
    Friend WithEvents feBautismoGBPadres As GroupBox
    Friend WithEvents feBautismoPadre As RadioButton
    Friend WithEvents feBautismoMadre As RadioButton
    Friend WithEvents feBautismoAmbosPadres As RadioButton
    Friend WithEvents feBautismoAdministradorSacramento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnFeBautismoGenerar As Button
    Friend WithEvents feBautismoDepartamentoNacimiento As ComboBox
    Friend WithEvents feBautismoNombrePadrino As TextBox
    Friend WithEvents feBautismoNombrePadre As TextBox
    Friend WithEvents feBautismoNombreMadre As TextBox
    Friend WithEvents feBautismoNombreConfirmado As TextBox
    Friend WithEvents feBautismoNumeroAsiento As TextBox
    Friend WithEvents feBautismoNumeroPagina As TextBox
    Friend WithEvents feBautismoNumeroLibro As TextBox
    Friend WithEvents feBautismoFechaNacimiento As DateTimePicker
    Friend WithEvents feBautismoFechaExtensión As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents feBautismoSacramentoConfirma As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActasDeConfirmaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeDeBautismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActaDeMatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
End Class
