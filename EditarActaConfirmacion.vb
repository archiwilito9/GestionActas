Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class EditarActaConfirmacion

    ' Propiedades para almacenar los datos
    Public Property id_actaConfirma As Integer
    Public Property NumLibroConfirma As Integer
    Public Property NumPaginaConfirma As Integer
    Public Property NumAsientoConfirma As Integer
    Public Property FechaAdministracionSacramento As DateTime
    Public Property AdministradorSacramento As String
    Public Property GeneroConfirmado As String
    Public Property NombreConfirmado As String
    Public Property DepartamentoNacimiento As String
    Public Property FechaNacimientoConfirmado As DateTime
    Public Property PadreConfirmado As String
    Public Property NombreMadre As String
    Public Property NombrePadre As String
    Public Property PadrinoConfirmado As String
    Public Property NombrePadrinos As String
    Public Property FechaExtensionConfirma As DateTime

    ' Método para configurar los datos
    Public Sub SetDatos(
        ID As Integer, numLibro As Integer, numPagina As Integer, numAsiento As Integer,
        fechaAdmin As DateTime, admin As String, genero As String, nombre As String,
        departamento As String, fechaNacimiento As DateTime, padre As String,
        madre As String, padreNombre As String, padrino As String, padrinoNombre As String,
        fechaExtension As DateTime)

        id_actaConfirma = ID
        NumLibroConfirma = numLibro
        NumPaginaConfirma = numPagina
        NumAsientoConfirma = numAsiento
        FechaAdministracionSacramento = fechaAdmin
        AdministradorSacramento = admin
        GeneroConfirmado = genero
        NombreConfirmado = nombre
        DepartamentoNacimiento = departamento
        FechaNacimientoConfirmado = fechaNacimiento
        PadreConfirmado = padre
        NombreMadre = madre
        NombrePadre = padreNombre
        PadrinoConfirmado = padrino
        NombrePadrinos = padrinoNombre
        FechaExtensionConfirma = fechaExtension
    End Sub
    Private Sub EditarActaConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Crear una matriz con los nombres de los departamentos de El Salvador
        Dim departamentos() As String = {"Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}

        ' Agregar los nombres de los departamentos al ComboBox
        actaConfirmaDepartamentoNacimiento.Items.AddRange(departamentos)


        actaConfirmaNumeroLibro.Text = NumLibroConfirma
        actaConfirmaNumeroPagina.Text = NumPaginaConfirma
        actaConfirmaNumeroAsiento.Text = NumAsientoConfirma
        actaConfirmaSacramentoConfirma.Value = FechaAdministracionSacramento
        actaConfirmaAdministradorSacramento.Text = AdministradorSacramento
        For Each control As Control In actaConfirmaGBGeneroConfirmado.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = GeneroConfirmado Then
                    radioButton.Checked = True
                End If
            End If
        Next
        actaConfirmaNombreConfirmado.Text = NombreConfirmado
        ' Recorrer las opciones del ComboBox
        For Each item As Object In actaConfirmaDepartamentoNacimiento.Items
            ' Verificar si el texto del elemento coincide con "si"
            If item.ToString() = DepartamentoNacimiento Then
                ' Establecer la selección en el ComboBox
                actaConfirmaDepartamentoNacimiento.SelectedItem = item
                Exit For ' Opcional: Salir del bucle una vez que se encuentra la coincidencia
            End If
        Next
        actaConfirmaFechaNacimiento.Value = FechaNacimientoConfirmado
        For Each control As Control In actaConfirmaGBPadres.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadreConfirmado Then
                    radioButton.Checked = True
                End If
            End If
        Next
        actaConfirmaNombreMadre.Text = NombreMadre
        actaConfirmaNombrePadre.Text = NombrePadre
        For Each control As Control In actaConfirmaGBPadrinos.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadrinoConfirmado Then
                    radioButton.Checked = True
                End If
            End If
        Next
        actaConfirmaNombrePadrino.Text = NombrePadrinos
        actaConfirmaFechaExtensión.Value = FechaExtensionConfirma
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim infoActaConfirma As New InformacionActaDeConfirmacion()
        infoActaConfirma.Show()
        Me.Close()

    End Sub

    Private Sub btnActaConfirmaGenerar_Click(sender As Object, e As EventArgs) Handles btnActaConfirmaGenerar.Click
        Dim infoConfirma As New InformacionActaDeConfirmacion()
        ' Construir la consulta SQL para actualizar los datos
        Dim consulta As String = "UPDATE Confirma SET " &
            "numLibroConfirma = @numLibroConfirma, " &
            "numPaginaConfirma = @numPaginaConfirma, " &
            "numAsientoConfirma = @numAsientoConfirma, " &
            "fechaAdministracionSacramento = @fechaAdministracionSacramento, " &
            "administradorSacramento = @administradorSacramento, " &
            "generoConfirmado = @generoConfirmado, " &
            "nombreConfirmado = @nombreConfirmado, " &
            "departamentoNacimiento = @departamentoNacimiento, " &
            "fechaNacimientoConfirmado = @fechaNacimientoConfirmado, " &
            "padreConfirmado = @padreConfirmado, " &
            "nombreMadre = @nombreMadre, " &
            "nombrePadre = @nombrePadre, " &
            "padrinoConfirmado = @padrinoConfirmado, " &
            "nombrePadrinos = @nombrePadrinos, " &
            "fechaExtensionConfirma = @fechaExtensionConfirma " &
            "WHERE id_actaConfirma = @id_actaConfirma"

        Using conn As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
            conn.Open()
            Using cmd As New SqlCommand(consulta, conn)
                ' Establecer los valores de los parámetros en la consulta
                cmd.Parameters.AddWithValue("@numLibroConfirma", actaConfirmaNumeroLibro.Text.Trim())
                cmd.Parameters.AddWithValue("@numPaginaConfirma", actaConfirmaNumeroPagina.Text.Trim())
                cmd.Parameters.AddWithValue("@numAsientoConfirma", actaConfirmaNumeroAsiento.Text.Trim())
                cmd.Parameters.AddWithValue("@fechaAdministracionSacramento", actaConfirmaSacramentoConfirma.Value)
                cmd.Parameters.AddWithValue("@administradorSacramento", actaConfirmaAdministradorSacramento.Text.Trim())
                cmd.Parameters.AddWithValue("@generoConfirmado", GetGroupBoxCheckedButton(actaConfirmaGBGeneroConfirmado).Text)
                cmd.Parameters.AddWithValue("@nombreConfirmado", actaConfirmaNombreConfirmado.Text.Trim())
                cmd.Parameters.AddWithValue("@departamentoNacimiento", actaConfirmaDepartamentoNacimiento.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@fechaNacimientoConfirmado", actaConfirmaFechaNacimiento.Value)
                cmd.Parameters.AddWithValue("@padreConfirmado", GetGroupBoxCheckedButton(actaConfirmaGBPadres).Text)
                cmd.Parameters.AddWithValue("@nombreMadre", actaConfirmaNombreMadre.Text.Trim())
                cmd.Parameters.AddWithValue("@nombrePadre", actaConfirmaNombrePadre.Text.Trim())
                cmd.Parameters.AddWithValue("@padrinoConfirmado", GetGroupBoxCheckedButton(actaConfirmaGBPadrinos).Text)
                cmd.Parameters.AddWithValue("@nombrePadrinos", actaConfirmaNombrePadrino.Text.Trim())
                cmd.Parameters.AddWithValue("@fechaExtensionConfirma", actaConfirmaFechaExtensión.Value)
                cmd.Parameters.AddWithValue("@id_actaConfirma", id_actaConfirma)

                ' Ejecutar la consulta SQL
                cmd.ExecuteNonQuery()

                MessageBox.Show("Los datos se han actualizado correctamente.")
                Me.Close()
                infoConfirma.Show()
            End Using
        End Using
    End Sub

    Private Function GetGroupBoxCheckedButton(grpb As System.Windows.Forms.GroupBox) As System.Windows.Forms.RadioButton
        For Each ctrl As System.Windows.Forms.RadioButton In grpb.Controls
            If ctrl.Checked Then Return ctrl
        Next
    End Function

    Public Sub soloNumeros(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' Si no es un número ni la tecla Backspace, cancelar la entrada
            e.Handled = True
        End If
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
End Class