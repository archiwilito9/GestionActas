Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Data.SqlClient
Public Class EditarActaMatrimonio

    ' Propiedades para almacenar los datos
    Public Property id_actaMatrimonio As Integer
    Public Property NumLibroMatrimonio As Integer
    Public Property NumActaMatrimonio As Integer
    Public Property FechaBendicionMatrimonio As DateTime
    Public Property AdministradorMatrimonio As String
    Public Property NombreNovio As String
    Public Property EdadNovio As Integer
    Public Property PadresNovio As String
    Public Property NombrePadreNovio As String
    Public Property NombreMadreNovio As String
    Public Property DepartamentoNovio As String
    Public Property NombreNovia As String
    Public Property EdadNovia As Integer
    Public Property PadresNovia As String
    Public Property NombrePadreNovia As String
    Public Property NombreMadreNovia As String
    Public Property DepartamentoNovia As String
    Public Property PadrinoMatrimonio As String
    Public Property NombrePadrino As String
    Public Property FechaExtension As DateTime

    ' Método para configurar los datos de actas de matrimonio
    Public Sub SetDatosMatrimonio(
    ID As Integer, numLibro As Integer, numActa As Integer,
    fechaBendicion As DateTime, admin As String, novio As String, anniosNovio As Integer,
    papasNovio As String, nombrePapaNovio As String, nombreMamaNovio As String, deptoNovio As String,
    novia As String, anniosNovia As Integer, papasNovia As String, nombrePapaNovia As String, nombreMamaNovia As String, deptoNovia As String,
    padrinosMatrimonio As String, nombrePadrinos As String, fechaExt As DateTime)

        id_actaMatrimonio = ID
        NumLibroMatrimonio = numLibro
        NumActaMatrimonio = numActa
        FechaBendicionMatrimonio = fechaBendicion
        AdministradorMatrimonio = admin
        NombreNovio = novio
        EdadNovio = anniosNovio
        PadresNovio = papasNovio
        NombrePadreNovio = nombrePapaNovio
        NombreMadreNovio = nombreMamaNovio
        DepartamentoNovio = deptoNovio
        NombreNovia = novia
        EdadNovia = anniosNovia
        PadresNovia = papasNovia
        NombrePadreNovia = nombrePapaNovia
        NombreMadreNovia = nombreMamaNovia
        DepartamentoNovia = deptoNovia
        PadrinoMatrimonio = padrinosMatrimonio
        NombrePadrino = nombrePadrinos
        FechaExtension = fechaExt
    End Sub
    Private Sub EditarActaMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Crear una matriz con los nombres de los departamentos de El Salvador
        Dim departamentos() As String = {"Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}

        ' Agregar los nombres de los departamentos al ComboBox
        actaMatrimonioDepartamentoNovio.Items.AddRange(departamentos)
        actaMatrimonioDepartamentoNovia.Items.AddRange(departamentos)


        actaMatrimonioNumeroLibro.Text = NumLibroMatrimonio
        actaMatrimonioNumeroActa.Text = NumActaMatrimonio
        actaMatrimonioFechaMatrimonio.Value = FechaBendicionMatrimonio
        actaMatrimonioAdministradorMatrimonio.Text = AdministradorMatrimonio
        'NOVIO
        actaMatrimonioNombreNovio.Text = NombreNovio
        actaMatrimonioEdadNovio.Text = EdadNovio
        For Each control As Control In actaMatrimonioGBPadresNovio.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadresNovio Then
                    radioButton.Checked = True
                End If
            End If
        Next
        actaMatrimonioNombrePadreNovio.Text = NombrePadreNovio
        actaMatrimonioNombreMadreNovio.Text = NombreMadreNovio
        ' Recorrer las opciones del ComboBox
        For Each item As Object In actaMatrimonioDepartamentoNovio.Items
            ' Verificar si el texto del elemento coincide con "si"
            If item.ToString() = DepartamentoNovio Then
                ' Establecer la selección en el ComboBox
                actaMatrimonioDepartamentoNovio.SelectedItem = item
                Exit For ' Opcional: Salir del bucle una vez que se encuentra la coincidencia
            End If
        Next
        'NOVIA
        actaMatrimonioNombreNovia.Text = NombreNovia
        actaMatrimonioEdadNovia.Text = EdadNovia
        For Each control As Control In actaMatrimonioGBPadresNovia.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadresNovia Then
                    radioButton.Checked = True
                End If
            End If
        Next
        actaMatrimonioNombrePadreNovia.Text = NombrePadreNovia
        actaMatrimonioNombreMadreNovia.Text = NombreMadreNovia
        ' Recorrer las opciones del ComboBox
        For Each item As Object In actaMatrimonioDepartamentoNovia.Items
            ' Verificar si el texto del elemento coincide con "si"
            If item.ToString() = DepartamentoNovia Then
                ' Establecer la selección en el ComboBox
                actaMatrimonioDepartamentoNovia.SelectedItem = item
                Exit For ' Opcional: Salir del bucle una vez que se encuentra la coincidencia
            End If
        Next
        'FINAL
        For Each control As Control In actaMatrimonioGBPadrinos.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadrinoMatrimonio Then
                    radioButton.Checked = True
                End If
            End If
        Next
        actaMatrimonioNombrePadrino.Text = NombrePadrino
        actaMatrimonioFechaExtension.Value = FechaExtension
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim actaMatrimonio As New InformacionActaDeMatrimonio()
        actaMatrimonio.Show()
        Me.Close()
    End Sub

    Private Sub btnActaMatrimonioGenerar_Click(sender As Object, e As EventArgs) Handles btnActaMatrimonioGenerar.Click
        Dim infoMatrimonio As New InformacionActaDeMatrimonio()
        ' Construir la consulta SQL para actualizar los datos
        Dim consulta As String = "UPDATE Matrimonio SET " &
            "numLibroMatrimonio = @numLibroMatrimonio, " &
            "numActaMatrimonio = @numActaMatrimonio, " &
            "fechaBendicionMatrimonio = @fechaBendicionMatrimonio, " &
            "administradorMatrimonio = @administradorMatrimonio, " &
            "nombreNovio = @nombreNovio, " &
            "edadNovio = @edadNovio, " &
            "padresNovio = @padresNovio, " &
            "nombrePadreNovio = @nombrePadreNovio, " &
            "nombreMadreNovio = @nombreMadreNovio, " &
            "departamentoNovio = @departamentoNovio, " &
            "nombreNovia = @nombreNovia, " &
            "edadNovia = @edadNovia, " &
            "padresNovia = @padresNovia, " &
            "nombrePadreNovia = @nombrePadreNovia, " &
            "nombreMadreNovia = @nombreMadreNovia, " &
            "departamentoNovia = @departamentoNovia, " &
            "padrinoMatrimonio = @padrinoMatrimonio, " &
            "nombrePadrino = @nombrePadrino, " &
            "fechaExtension = @fechaExtension " &
            "WHERE id_actaMatrimonio = @id_actaMatrimonio"

        Using conn As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
            conn.Open()
            Using cmd As New SqlCommand(consulta, conn)
                ' Establecer los valores de los parámetros en la consulta
                cmd.Parameters.AddWithValue("@numLibroMatrimonio", actaMatrimonioNumeroLibro.Text.Trim())
                cmd.Parameters.AddWithValue("@numActaMatrimonio", actaMatrimonioNumeroActa.Text.Trim())
                cmd.Parameters.AddWithValue("@fechaBendicionMatrimonio", actaMatrimonioFechaMatrimonio.Value)
                cmd.Parameters.AddWithValue("@administradorMatrimonio", actaMatrimonioAdministradorMatrimonio.Text.Trim())
                cmd.Parameters.AddWithValue("@nombreNovio", actaMatrimonioNombreNovio.Text.Trim())
                cmd.Parameters.AddWithValue("@edadNovio", actaMatrimonioEdadNovio.Text.Trim())
                cmd.Parameters.AddWithValue("@padresNovio", GetGroupBoxCheckedButton(actaMatrimonioGBPadresNovio).Text)
                cmd.Parameters.AddWithValue("@nombrePadreNovio", actaMatrimonioNombrePadreNovio.Text.Trim())
                cmd.Parameters.AddWithValue("@nombreMadreNovio", actaMatrimonioNombreMadreNovio.Text.Trim())
                cmd.Parameters.AddWithValue("@departamentoNovio", actaMatrimonioDepartamentoNovio.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@nombreNovia", actaMatrimonioNombreNovia.Text.Trim())
                cmd.Parameters.AddWithValue("@edadNovia", actaMatrimonioEdadNovio.Text.Trim())
                cmd.Parameters.AddWithValue("@padresNovia", GetGroupBoxCheckedButton(actaMatrimonioGBPadresNovia).Text)
                cmd.Parameters.AddWithValue("@nombrePadreNovia", actaMatrimonioNombrePadreNovia.Text.Trim())
                cmd.Parameters.AddWithValue("@nombreMadreNovia", actaMatrimonioNombreMadreNovia.Text.Trim())
                cmd.Parameters.AddWithValue("@departamentoNovia", actaMatrimonioDepartamentoNovia.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@padrinoMatrimonio", GetGroupBoxCheckedButton(actaMatrimonioGBPadrinos).Text)
                cmd.Parameters.AddWithValue("@nombrePadrino", actaMatrimonioNombrePadrino.Text.Trim())
                cmd.Parameters.AddWithValue("@fechaExtension", actaMatrimonioFechaExtension.Value)
                cmd.Parameters.AddWithValue("@id_actaMatrimonio", id_actaMatrimonio)

                ' Ejecutar la consulta SQL
                cmd.ExecuteNonQuery()

                MessageBox.Show("Los datos se han actualizado correctamente.")
                Me.Close()
                infoMatrimonio.Show()
            End Using
        End Using
    End Sub
End Class