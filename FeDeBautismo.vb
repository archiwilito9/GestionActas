Public Class FeDeBautismo
    Private Sub btnFeBautismoGenerar_Click(sender As Object, e As EventArgs) Handles btnFeBautismoGenerar.Click
        Dim infoBautismo As New InformacionFeDeBautismo()
        ' Arreglo para almacenar los TextBox
        Dim textBoxes() As System.Windows.Forms.TextBox = {feBautismoNumeroLibro, feBautismoNumeroPagina, feBautismoNumeroAsiento, feBautismoNombreConfirmado, feBautismoNombrePadrino}

        ' Verificar si alguno de los TextBox está vacío
        For Each caja As System.Windows.Forms.TextBox In textBoxes
            If String.IsNullOrWhiteSpace(caja.Text) Then
                MessageBox.Show("No pueden haber campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Detener la ejecución
            End If
        Next

        'Obtener fechas'
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechaFeBautismo As Date = feBautismoSacramentoConfirma.Value
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechafeBautismoFechaNacimiento As Date = feBautismoFechaNacimiento.Value
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechafeBautismoFechaExtensión As Date = feBautismoFechaExtensión.Value


        CrearFeBautismo(feBautismoNumeroLibro.Text, feBautismoNumeroPagina.Text, feBautismoNumeroAsiento.Text, fechaFeBautismo, feBautismoAdministradorSacramento.Text, GetGroupBoxCheckedButton(feBautismoGBGeneroConfirmado), feBautismoNombreConfirmado.Text, feBautismoDepartamentoNacimiento.SelectedItem.ToString(), fechafeBautismoFechaNacimiento, GetGroupBoxCheckedButton(feBautismoGBPadres), feBautismoNombreMadre.Text, feBautismoNombrePadre.Text, GetGroupBoxCheckedButton(feBautismoGBPadrinos), feBautismoNombrePadrino.Text, fechafeBautismoFechaExtensión)
        Me.Close()
        infoBautismo.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub feBautismoNumeroLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles feBautismoNumeroLibro.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub feBautismoNumeroPagina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles feBautismoNumeroPagina.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub feBautismoNumeroAsiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles feBautismoNumeroAsiento.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub FeDeBautismo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Crear una matriz con los nombres de los departamentos de El Salvador
        Dim departamentos() As String = {"Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}

        ' Agregar los nombres de los departamentos al ComboBox
        feBautismoDepartamentoNacimiento.Items.AddRange(departamentos)
        feBautismoDepartamentoNacimiento.SelectedIndex = 0
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Crear una instancia del formulario Form2
        Dim feBautismo As New InformacionFeDeBautismo()

        ' Mostrar el formulario Form2
        feBautismo.Show()
        Me.Close()
    End Sub

    Private Sub ActasDeConfirmaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActasDeConfirmaciónToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim actaDeConfirmacion As New InformacionActaDeConfirmacion()

        ' Mostrar el formulario Form2
        actaDeConfirmacion.Show()
        Me.Close()
    End Sub

    Private Sub ActaDeMatrimonioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActaDeMatrimonioToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim actaDeMatrimonio As New InformacionActaDeMatrimonio()

        ' Mostrar el formulario Form2
        actaDeMatrimonio.Show()
        Me.Close()
    End Sub
End Class