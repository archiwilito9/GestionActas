
Imports System.Data.SqlClient

Public Class InformacionActaDeMatrimonio
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub InformacionActaDeMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim infoBuscador() As String = {"Novio", "Novia"}

        ' Agregar los nombres de los departamentos al ComboBox
        actaMatrimonioBuscador.Items.AddRange(infoBuscador)
        actaMatrimonioBuscador.SelectedIndex = 0
        conexion = New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
        'Conexion.Open()
        'Dim consulta As String = "SELECT * FROM Confirma"
        llenarTabla("SELECT id_actaMatrimonio, nombreNovio, nombreNovia FROM Matrimonio")

        ' Cambia el texto del encabezado de la cuarta columna
        DataGridView1.Columns(3).HeaderText = "Código"

        ' Cambia el texto del encabezado de la primera columna
        DataGridView1.Columns(4).HeaderText = "Novio"

        ' Cambia el texto del encabezado de la segunda columna
        DataGridView1.Columns(5).HeaderText = "Novia"

        ' Cambia el texto del encabezado de la tercera columna
        'DataGridView1.Columns(3).HeaderText = "Fecha de matrimonio"

        ' Cambia el texto del encabezado de la quinta columna
        'DataGridView1.Columns(4).HeaderText = "Fecha de extensión"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Columns("btnGenerar").DisplayIndex = DataGridView1.Columns.Count - 1
        DataGridView1.Columns("btnEditar").DisplayIndex = DataGridView1.Columns.Count - 1
        DataGridView1.Columns("btnEliminar").DisplayIndex = DataGridView1.Columns.Count - 1
        DataGridView1.Columns(3).Visible = False
        TextBox1.Focus()
    End Sub

    Public Sub llenarTabla(consultaLlamada As String)
        Dim consulta As String = consultaLlamada
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ActualizarDataGridView(filtro As String)
        Dim consulta As String

        If String.IsNullOrEmpty(filtro) Then
            consulta = "SELECT id_actaMatrimonio, nombreNovio, nombreNovia FROM Matrimonio"
            llenarTabla(consulta)
        Else
            If actaMatrimonioBuscador.SelectedItem.ToString() = "Novio" Then
                consulta = "SELECT id_actaMatrimonio, nombreNovio, nombreNovia FROM Matrimonio WHERE LOWER(nombreNovio) LIKE LOWER('%" & filtro & "%')"
                llenarTabla(consulta)
            Else
                consulta = "SELECT id_actaMatrimonio, nombreNovio, nombreNovia FROM Matrimonio WHERE LOWER(nombreNovia) LIKE LOWER('%" & filtro & "%')"
                llenarTabla(consulta)
            End If
        End If
    End Sub
    Private filtro As String = ""
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Obtener el texto del TextBox
        filtro = TextBox1.Text.Trim()

        ' Actualizar el DataGridView basado en el filtro
        ActualizarDataGridView(filtro)

        ' Si el TextBox está vacío, mostrar todos los registros
        If String.IsNullOrEmpty(filtro) Then
            ActualizarDataGridView("")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim actaDeMatrimonio As New ActaDeMatrimonio()

        ' Mostrar el formulario Form2
        actaDeMatrimonio.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub actaMatrimonioBuscador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles actaMatrimonioBuscador.SelectionChangeCommitted
        TextBox1.Clear()
        ActualizarDataGridView(filtro)
    End Sub

    Private Sub FeDeBautismoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeDeBautismoToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim feDeBautismo As New InformacionFeDeBautismo()

        ' Mostrar el formulario Form2
        feDeBautismo.Show()
        Me.Close()
    End Sub

    Private Sub ActasDeConfirmaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActasDeConfirmaciónToolStripMenuItem.Click
        Dim actaDeConfirmación As New InformacionActaDeConfirmacion()

        ' Mostrar el formulario Form2
        actaDeConfirmación.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'GENERAR ACTA
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            ' Obtiene el valor de la celda seleccionada
            Dim valorCelda As String = DataGridView1.Rows(e.RowIndex).Cells("id_actaMatrimonio").Value.ToString()
            ' Realiza una consulta a la base de datos para obtener los datos completos
            Dim consulta As String = "SELECT * FROM Matrimonio WHERE id_actaMatrimonio = " & valorCelda.Trim()
            Using conn As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
                conn.Open()
                Using cmd As New SqlCommand(consulta, conn)
                    cmd.Parameters.AddWithValue("@id_actaMatrimonio", valorCelda)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Aquí puedes obtener los datos completos y mostrarlos en un MessageBox
                            Dim fechaSQLBendicionMatrimonio As DateTime = Convert.ToDateTime(reader("fechaBendicionMatrimonio"))
                            Dim fechaSQLExtension As DateTime = Convert.ToDateTime(reader("fechaExtension"))
                            CrearActaMatrimonio(reader("numLibroMatrimonio"), reader("numActaMatrimonio"), fechaSQLBendicionMatrimonio, reader("administradorMatrimonio"), reader("nombreNovio"), reader("edadNovio"), reader("padresNovio"), reader("nombrePadreNovio"), reader("nombreMadreNovio"), reader("departamentoNovio"), reader("nombreNovia"), reader("edadNovia"), reader("padresNovia"), reader("nombrePadreNovia"), reader("nombreMadreNovia"), reader("departamentoNovia"), reader("padrinoMatrimonio"), reader("nombrePadrino"), fechaSQLExtension)
                        End If
                    End Using
                End Using
            End Using
        End If
        'EDITAR ACTA
        'EDITAR'
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then
            ' Verificar si se hizo clic en la columna "Editar"
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim id As Integer = CInt(filaSeleccionada.Cells("id_actaMatrimonio").Value) ' Obtener el ID

            ' Realizar una consulta SQL para cargar los datos del ID seleccionado
            Dim consulta As String = "SELECT * FROM Matrimonio WHERE id_actaMatrimonio = @ID"
            Using conn As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
                conn.Open()
                Using cmd As New SqlCommand(consulta, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim actualizarMatrimonio As New EditarActaMatrimonio()
                            actualizarMatrimonio.SetDatosMatrimonio(
                                CInt(reader("id_actaMatrimonio")),
                                CInt(reader("numLibroMatrimonio")),
                                CInt(reader("numActaMatrimonio")),
                                CDate(reader("fechaBendicionMatrimonio")),
                                reader("administradorMatrimonio").ToString(),
                                reader("nombreNovio").ToString(),
                                CInt(reader("edadNovio")),
                                reader("padresNovio").ToString(),
                                reader("nombrePadreNovio").ToString(),
                                reader("nombreMadreNovio").ToString(),
                                reader("departamentoNovio").ToString(),
                                reader("nombreNovia").ToString(),
                                CInt(reader("edadNovia")),
                                reader("padresNovia").ToString(),
                                reader("nombrePadreNovia").ToString(),
                                reader("nombreMadreNovia").ToString(),
                                reader("departamentoNovia").ToString(),
                                reader("padrinoMatrimonio").ToString(),
                                reader("nombrePadrino").ToString(),
                                CDate(reader("fechaExtension"))
                                )
                            actualizarMatrimonio.Show()
                            Me.Close()

                            ' Realizar acciones después de cerrar el formulario de edición si es necesario
                        End If
                    End Using
                End Using
            End Using
        End If
        'End If
        'ELIMINAR ACTA
        If e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then
            ' Obtén el valor de la celda seleccionada
            Dim valorCelda As String = DataGridView1.Rows(e.RowIndex).Cells("id_actaMatrimonio").Value.ToString()

            ' Muestra un cuadro de diálogo de confirmación
            Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' El usuario confirmó la eliminación, realiza la eliminación del registro en la base de datos
                Dim consultaEliminacion As String = "DELETE FROM Matrimonio WHERE id_actaMatrimonio = @id_actaMatrimonio"

                Using conn As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")
                    conn.Open()

                    Using cmd As New SqlCommand(consultaEliminacion, conn)
                        cmd.Parameters.AddWithValue("@id_actaMatrimonio", valorCelda)

                        If cmd.ExecuteNonQuery() > 0 Then
                            ' La eliminación fue exitosa, puedes realizar acciones adicionales si es necesario
                            MessageBox.Show("El registro se ha eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Recarga los datos en el DataGridView para reflejar el cambio
                            ActualizarDataGridView("")
                        Else
                            ' La eliminación falló
                            MessageBox.Show("Error al eliminar el registro. Verifica los datos e inténtalo de nuevo.", "Error en la eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End If
        End If
    End Sub
End Class