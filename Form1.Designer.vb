<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        actasDeConfirmacionToolStripMenuItem = New ToolStripMenuItem()
        FeDeBautismoToolStripMenuItem = New ToolStripMenuItem()
        ActaDeMatrimonioToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraciónToolStripMenuItem = New ToolStripMenuItem()
        BaseDeDatosToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ConfiguraciónToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(673, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {actasDeConfirmacionToolStripMenuItem, FeDeBautismoToolStripMenuItem, ActaDeMatrimonioToolStripMenuItem})
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(48, 20)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' actasDeConfirmacionToolStripMenuItem
        ' 
        actasDeConfirmacionToolStripMenuItem.Name = "actasDeConfirmacionToolStripMenuItem"
        actasDeConfirmacionToolStripMenuItem.Size = New Size(180, 22)
        actasDeConfirmacionToolStripMenuItem.Text = "Acta de confirma"
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
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(191, 88)
        Button1.Name = "Button1"
        Button1.Size = New Size(321, 74)
        Button1.TabIndex = 3
        Button1.Text = "Acta de confirmación"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(191, 194)
        Button2.Name = "Button2"
        Button2.Size = New Size(321, 74)
        Button2.TabIndex = 4
        Button2.Text = "Fe de bautismo"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(191, 309)
        Button3.Name = "Button3"
        Button3.Size = New Size(321, 74)
        Button3.TabIndex = 5
        Button3.Text = "Acta de matrimonio"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(191, 417)
        Button4.Name = "Button4"
        Button4.Size = New Size(321, 74)
        Button4.TabIndex = 6
        Button4.Text = "Salir"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(673, 516)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Parroquia Nuestra Señora de La Paz"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents actasDeConfirmacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeDeBautismoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActaDeMatrimonioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
End Class
