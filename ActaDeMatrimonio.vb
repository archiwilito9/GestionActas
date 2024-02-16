Public Class ActaDeMatrimonio
    Private Sub btnActaMatrimonioGenerar_Click(sender As Object, e As EventArgs) Handles btnActaMatrimonioGenerar.Click
        Dim infoMatrimonio As New InformacionActaDeMatrimonio()
        ' Arreglo para almacenar los TextBox
        Dim textBoxes() As System.Windows.Forms.TextBox = {actaMatrimonioNumeroLibro, actaMatrimonioNumeroActa, actaMatrimonioAdministradorMatrimonio, actaMatrimonioNombreNovio, actaMatrimonioEdadNovio, actaMatrimonioNombreNovia, actaMatrimonioEdadNovia, actaMatrimonioNombrePadrino}

        ' Verificar si alguno de los TextBox está vacío
        'For Each caja As System.Windows.Forms.TextBox In textBoxes
        '    If String.IsNullOrWhiteSpace(caja.Text) Then
        '        MessageBox.Show("No pueden haber campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Return ' Detener la ejecución
        '    End If
        'Next

        'Obtener fechas'
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechaActaMatrimonioBoda As Date = actaMatrimonioFechaMatrimonio.Value
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechaActaMatrimonioFechaExtensión As Date = actaMatrimonioFechaExtension.Value

        CrearActaMatrimonio(actaMatrimonioNumeroLibro.Text, actaMatrimonioNumeroActa.Text, fechaActaMatrimonioBoda, actaMatrimonioAdministradorMatrimonio.Text, actaMatrimonioNombreNovio.Text, actaMatrimonioEdadNovio.Text, GetGroupBoxCheckedButton(actaMatrimonioGBPadresNovio), actaMatrimonioNombrePadreNovio.Text, actaMatrimonioNombreMadreNovio.Text, actaMatrimonioDepartamentoNovio.SelectedItem.ToString(), actaMatrimonioNombreNovia.Text, actaMatrimonioEdadNovia.Text, GetGroupBoxCheckedButton(actaMatrimonioGBPadresNovia), actaMatrimonioNombrePadreNovia.Text, actaMatrimonioNombreMadreNovia.Text, actaMatrimonioDepartamentoNovia.SelectedItem.ToString(), GetGroupBoxCheckedButton(actaMatrimonioGBPadrinos), actaMatrimonioNombrePadrino.Text, fechaActaMatrimonioFechaExtensión)
        Me.Close()
        infoMatrimonio.Show()
    End Sub
    Public Sub soloNumeros(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' Si no es un número ni la tecla Backspace, cancelar la entrada
            e.Handled = True
        End If
    End Sub

    Private Function GetGroupBoxCheckedButton(grpb As System.Windows.Forms.GroupBox) As System.Windows.Forms.RadioButton
        For Each ctrl As System.Windows.Forms.RadioButton In grpb.Controls
            If ctrl.Checked Then Return ctrl
        Next
    End Function

    Private Sub actaMatrimonioNumeroLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaMatrimonioNumeroLibro.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub actaMatrimonioNumeroActa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaMatrimonioNumeroActa.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub actaMatrimonioEdadNovio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaMatrimonioEdadNovio.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub actaMatrimonioEdadNovia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaMatrimonioEdadNovia.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub ActaDeMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Crear una matriz con los nombres de los departamentos de El Salvador
        Dim departamentos() As String = {"Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}

        ' Agregar los nombres de los departamentos al ComboBox
        actaMatrimonioDepartamentoNovio.Items.AddRange(departamentos)
        actaMatrimonioDepartamentoNovio.SelectedIndex = 0

        actaMatrimonioDepartamentoNovia.Items.AddRange(departamentos)
        actaMatrimonioDepartamentoNovia.SelectedIndex = 0
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Crear una instancia del formulario Form2
        Dim actaMatrimonio As New InformacionActaDeMatrimonio()

        ' Mostrar el formulario Form2
        actaMatrimonio.Show()
        Me.Close()
    End Sub

    Private Sub ActasDeConfirmaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActasDeConfirmaciónToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim actaDeConfirmacion As New InformacionActaDeConfirmacion()

        ' Mostrar el formulario Form2
        actaDeConfirmacion.Show()
        Me.Close()
    End Sub

    Private Sub FeDeBautismoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeDeBautismoToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim feDeBautismo As New InformacionFeDeBautismo()

        ' Mostrar el formulario Form2
        feDeBautismo.Show()
        Me.Close()
    End Sub
End Class