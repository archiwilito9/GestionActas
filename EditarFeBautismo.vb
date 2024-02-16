Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class EditarFeBautismo
    ' Propiedades para almacenar los datos
    Public Property id_feBautismo As Integer
    Public Property NumLibroBautismo As Integer
    Public Property NumPaginaBautismo As Integer
    Public Property NumAsientoBautismo As Integer
    Public Property FechaAdministracionSacramento As DateTime
    Public Property AdministradorSacramento As String
    Public Property GeneroBautizado As String
    Public Property NombreBautizado As String
    Public Property DepartamentoNacimiento As String
    Public Property FechaNacimientoBautizado As DateTime
    Public Property PadreBautizado As String
    Public Property NombreMadre As String
    Public Property NombrePadre As String
    Public Property PadrinoBautizado As String
    Public Property NombrePadrinos As String
    Public Property FechaExtensionBautismo As DateTime

    ' Método para configurar los datos
    Public Sub SetDatos(
        ID As Integer, numLibro As Integer, numPagina As Integer, numAsiento As Integer,
        fechaAdmin As DateTime, admin As String, genero As String, nombre As String,
        departamento As String, fechaNacimiento As DateTime, padre As String,
        madre As String, padreNombre As String, padrino As String, padrinoNombre As String,
        fechaExtension As DateTime)

        id_feBautismo = ID
        NumLibroBautismo = numLibro
        NumPaginaBautismo = numPagina
        NumAsientoBautismo = numAsiento
        FechaAdministracionSacramento = fechaAdmin
        AdministradorSacramento = admin
        GeneroBautizado = genero
        NombreBautizado = nombre
        DepartamentoNacimiento = departamento
        FechaNacimientoBautizado = fechaNacimiento
        PadreBautizado = padre
        NombreMadre = madre
        NombrePadre = padreNombre
        PadrinoBautizado = padrino
        NombrePadrinos = padrinoNombre
        FechaExtensionBautismo = fechaExtension
    End Sub
    Private Sub btnFeBautismoGenerar_Click(sender As Object, e As EventArgs) Handles btnFeBautismoGenerar.Click
        Dim infoBautismo As New InformacionFeDeBautismo()
        ' Construir la consulta SQL para actualizar los datos
        Dim consulta As String = "UPDATE Bautismo SET " &
            "numLibroBautismo = @numLibroBautismo, " &
            "numPaginaBautismo = @numPaginaBautismo, " &
            "numAsientoBautismo = @numAsientoBautismo, " &
            "fechaAdministracionSacramento = @fechaAdministracionSacramento, " &
            "administradorSacramento = @administradorSacramento, " &
            "generoBautizado = @generoBautizado, " &
            "nombreBautizado = @nombreBautizado, " &
            "departamentoNacimiento = @departamentoNacimiento, " &
            "fechaNacimientoBautizado = @fechaNacimientoBautizado, " &
            "padreBautizado = @padreBautizado, " &
            "nombreMadre = @nombreMadre, " &
            "nombrePadre = @nombrePadre, " &
            "padrinoBautizado = @padrinoBautizado, " &
            "nombrePadrinos = @nombrePadrinos, " &
            "fechaExtensionBautismo = @fechaExtensionBautismo " &
            "WHERE id_feBautismo = @id_feBautismo"

        Using conn As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
            conn.Open()
            Using cmd As New SqlCommand(consulta, conn)
                ' Establecer los valores de los parámetros en la consulta
                cmd.Parameters.AddWithValue("@numLibroBautismo", feBautismoNumeroLibro.Text.Trim())
                cmd.Parameters.AddWithValue("@numPaginaBautismo", feBautismoNumeroPagina.Text.Trim())
                cmd.Parameters.AddWithValue("@numAsientoBautismo", feBautismoNumeroAsiento.Text.Trim())
                cmd.Parameters.AddWithValue("@fechaAdministracionSacramento", feBautismoSacramentoConfirma.Value)
                cmd.Parameters.AddWithValue("@administradorSacramento", feBautismoAdministradorSacramento.Text.Trim())
                cmd.Parameters.AddWithValue("@generoBautizado", GetGroupBoxCheckedButton(feBautismoGBGeneroConfirmado).Text)
                cmd.Parameters.AddWithValue("@nombreBautizado", feBautismoNombreConfirmado.Text.Trim())
                cmd.Parameters.AddWithValue("@departamentoNacimiento", feBautismoDepartamentoNacimiento.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@fechaNacimientoBautizado", feBautismoFechaNacimiento.Value)
                cmd.Parameters.AddWithValue("@padreBautizado", GetGroupBoxCheckedButton(feBautismoGBPadres).Text)
                cmd.Parameters.AddWithValue("@nombreMadre", feBautismoNombreMadre.Text.Trim())
                cmd.Parameters.AddWithValue("@nombrePadre", feBautismoNombrePadre.Text.Trim())
                cmd.Parameters.AddWithValue("@padrinoBautizado", GetGroupBoxCheckedButton(feBautismoGBPadrinos).Text)
                cmd.Parameters.AddWithValue("@nombrePadrinos", feBautismoNombrePadrino.Text.Trim())
                cmd.Parameters.AddWithValue("@fechaExtensionBautismo", feBautismoFechaExtensión.Value)
                cmd.Parameters.AddWithValue("@id_feBautismo", id_feBautismo)

                ' Ejecutar la consulta SQL
                cmd.ExecuteNonQuery()

                MessageBox.Show("Los datos se han actualizado correctamente.")
                Me.Close()
                infoBautismo.Show()
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formularioBautismo As New InformacionFeDeBautismo()
        formularioBautismo.Show()
        Me.Close()
    End Sub

    Private Sub EditarFeBautismo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Crear una matriz con los nombres de los departamentos de El Salvador
        Dim departamentos() As String = {"Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "La Libertad", "La Paz", "La Unión", "Morazán", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}

        ' Agregar los nombres de los departamentos al ComboBox
        feBautismoDepartamentoNacimiento.Items.AddRange(departamentos)

        feBautismoNumeroLibro.Text = NumLibroBautismo
        feBautismoNumeroPagina.Text = NumPaginaBautismo
        feBautismoNumeroAsiento.Text = NumAsientoBautismo
        feBautismoSacramentoConfirma.Value = FechaAdministracionSacramento
        feBautismoAdministradorSacramento.Text = AdministradorSacramento
        For Each control As Control In feBautismoGBGeneroConfirmado.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = GeneroBautizado Then
                    radioButton.Checked = True
                End If
            End If
        Next
        feBautismoNombreConfirmado.Text = NombreBautizado
        ' Recorrer las opciones del ComboBox
        For Each item As Object In feBautismoDepartamentoNacimiento.Items
            ' Verificar si el texto del elemento coincide con "si"
            If item.ToString() = DepartamentoNacimiento Then
                ' Establecer la selección en el ComboBox
                feBautismoDepartamentoNacimiento.SelectedItem = item
                Exit For ' Opcional: Salir del bucle una vez que se encuentra la coincidencia
            End If
        Next
        feBautismoFechaNacimiento.Value = FechaNacimientoBautizado
        For Each control As Control In feBautismoGBPadres.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadreBautizado Then
                    radioButton.Checked = True
                End If
            End If
        Next
        feBautismoNombreMadre.Text = NombreMadre
        feBautismoNombrePadre.Text = NombrePadre
        For Each control As Control In feBautismoGBPadrinos.Controls
            If TypeOf control Is System.Windows.Forms.RadioButton Then
                ' Verificar si el texto del RadioButton coincide con el texto deseado
                Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(control, System.Windows.Forms.RadioButton)
                If radioButton.Text = PadrinoBautizado Then
                    radioButton.Checked = True
                End If
            End If
        Next
        feBautismoNombrePadrino.Text = NombrePadrinos
        feBautismoFechaExtensión.Value = FechaExtensionBautismo
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

    Private Sub feBautismoNumeroLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles feBautismoNumeroLibro.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub feBautismoNumeroPagina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles feBautismoNumeroPagina.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub feBautismoNumeroAsiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles feBautismoNumeroAsiento.KeyPress
        soloNumeros(e)
    End Sub
End Class