Public Class ActaDeConfirmación
    Dim clasePrincipal As New Form1()
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub soloNumeros(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' Si no es un número ni la tecla Backspace, cancelar la entrada
            e.Handled = True
        End If
    End Sub

    Private Sub ActaDeConfirmación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Crear una matriz con los nombres de los departamentos de El Salvador
        Dim departamentos() As String = {"Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}

        ' Agregar los nombres de los departamentos al ComboBox
        actaConfirmaDepartamentoNacimiento.Items.AddRange(departamentos)
        actaConfirmaDepartamentoNacimiento.SelectedIndex = 0
    End Sub

    Private Sub actaConfirmaNumeroLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaConfirmaNumeroLibro.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub actaConfirmaNumeroPagina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaConfirmaNumeroPagina.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub actaConfirmaNumeroAsiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles actaConfirmaNumeroAsiento.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnActaConfirmaGenerar_Click(sender As Object, e As EventArgs) Handles btnActaConfirmaGenerar.Click
        ' Arreglo para almacenar los TextBox
        Dim infoConfirma As New InformacionActaDeConfirmacion()
        Dim textBoxes() As System.Windows.Forms.TextBox = {actaConfirmaNumeroLibro, actaConfirmaNumeroPagina, actaConfirmaNumeroAsiento, actaConfirmaNombreConfirmado, actaConfirmaNombrePadrino}

        ' Verificar si alguno de los TextBox está vacío
        For Each caja As System.Windows.Forms.TextBox In textBoxes
            If String.IsNullOrWhiteSpace(caja.Text) Then
                MessageBox.Show("No pueden haber campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Detener la ejecución
            End If
        Next

        'Obtener fechas'
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechaActaConfirmaSacramentoConfirma As Date = actaConfirmaSacramentoConfirma.Value
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechaActaConfirmaFechaNacimiento As Date = actaConfirmaFechaNacimiento.Value
        ' Obtén la fecha seleccionada en el DateTimePicker
        Dim fechaActaConfirmaFechaExtensión As Date = actaConfirmaFechaExtensión.Value


        CrearActaConfirma(actaConfirmaNumeroLibro.Text, actaConfirmaNumeroPagina.Text, actaConfirmaNumeroAsiento.Text, fechaActaConfirmaSacramentoConfirma, actaConfirmaAdministradorSacramento.Text, GetGroupBoxCheckedButton(actaConfirmaGBGeneroConfirmado), actaConfirmaNombreConfirmado.Text, actaConfirmaDepartamentoNacimiento.SelectedItem.ToString(), fechaActaConfirmaFechaNacimiento, GetGroupBoxCheckedButton(actaConfirmaGBPadres), actaConfirmaNombreMadre.Text, actaConfirmaNombrePadre.Text, GetGroupBoxCheckedButton(actaConfirmaGBPadrinos), actaConfirmaNombrePadrino.Text, fechaActaConfirmaFechaExtensión)
        Me.Close()
        infoConfirma.Show()
    End Sub

    Private Function GetGroupBoxCheckedButton(grpb As System.Windows.Forms.GroupBox) As System.Windows.Forms.RadioButton
        For Each ctrl As System.Windows.Forms.RadioButton In grpb.Controls
            If ctrl.Checked Then Return ctrl
        Next
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Crear una instancia del formulario Form2
        Dim actaConfirmacion As New InformacionActaDeConfirmacion()

        ' Mostrar el formulario Form2
        actaConfirmacion.Show()
        Me.Close()
    End Sub

    Private Sub FeDeBautismoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeDeBautismoToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim feDeBautismo As New InformacionFeDeBautismo()

        ' Mostrar el formulario Form2
        feDeBautismo.Show()
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