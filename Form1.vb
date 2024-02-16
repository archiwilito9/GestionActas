Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    'Private Sub btnLeerDocumento_Click(sender As Object, e As EventArgs) Handles btnLeerDocumento.Click

    '    '' Configura el OpenFileDialog
    '    'OpenFileDialog1.Title = "Seleccionar un archivo"
    '    'OpenFileDialog1.Filter = "Todos los archivos (*.*)|*.*"

    '    '' Muestra el diálogo y espera a que el usuario seleccione un archivo
    '    'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
    '    '    ' Obtiene la ruta del archivo seleccionado
    '    '    Dim filePath As String = OpenFileDialog1.FileName

    '    '    ' Muestra la ruta en el TextBox de la ruta del archivo
    '    '    Dim wordApp As New Word.Application()
    '    '    Try
    '    '        Dim doc As Word.Document = wordApp.Documents.Open(filePath)
    '    '        ' La variable docText tiene el texto del documento de word
    '    '        Dim docText As String = doc.Content.Text

    '    '        ' Define el patrón de expresión regular para encontrar el texto entre "Hola," y "amo".
    '    '        Dim patron1 As String = "Hola (.*?),"
    '    '        Dim patron2 As String = "tienes (.*?) años"
    '    '        ' Realiza la búsqueda utilizando la expresión regular.
    '    '        Dim nombre As MatchCollection = Regex.Matches(docText, patron1)
    '    '        Dim edad As MatchCollection = Regex.Matches(docText, patron2)

    '    '        ' Si se encuentra al menos una coincidencia, obtén el texto entre "Hola," y "amo" de la primera coincidencia.
    '    '        If nombre.Count > 0 And edad.Count > 0 Then
    '    '            Dim nombreDeseado As String = nombre(0).Groups(1).Value.Trim()
    '    '            Dim edadDeseada As String = edad(0).Groups(1).Value.Trim()
    '    '            ' Aquí tienes el texto deseado.
    '    '            MessageBox.Show("Nombre: " & nombreDeseado & vbCr & "Edad: " & edadDeseada)
    '    '        Else
    '    '            ' No se encontró el patrón en el texto.
    '    '            MessageBox.Show("No se encontró el patrón en el texto.")
    '    '        End If

    '    '        ' docText = docText.Replace("Hola", "Hola Marvin")



    '    '        txtDocumento.Text = docText
    '    '        doc.Close()
    '    '    Catch ex As Exception
    '    '        MessageBox.Show("Error al abrir el documento: " & ex.Message)
    '    '    Finally
    '    '        wordApp.Quit()
    '    '    End Try
    '    'End If
    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub actasDeConfirmacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles actasDeConfirmacionToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim actaDeConfirmación As New InformacionActaDeConfirmacion()

        ' Mostrar el formulario Form2
        actaDeConfirmación.Show()
        'Me.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    'MessageBox.Show(ConvertirAnnioTextoANumero("mil novecientos cincuenta y dos"))
    'End Sub

    Function ConvertirAnnioTextoANumero(texto As String) As Integer
        '    Dim palabras As String() = texto.Split(New Char() {" "c, "-"c}, StringSplitOptions.RemoveEmptyEntries) ' Ahora se dividen las palabras por espacio y guión "-"
        '    Dim resultado As Integer = 0
        '    Dim sumaTemporal As Integer = 0


        '    ' Variable para controlar si se ha detectado "dos mil"
        '    Dim dosMilDetectado As Boolean = False

        '    For i As Integer = 0 To palabras.Length - 1
        '        If palabras(i) = "dos" AndAlso Not dosMilDetectado Then
        '            ' Verificar si la siguiente palabra es "mil"
        '            If i < palabras.Length - 1 AndAlso palabras(i + 1) = "mil" Then
        '                sumaTemporal += 2000
        '                dosMilDetectado = True
        '                i += 1 ' Saltar la siguiente palabra ("mil")
        '            Else
        '                sumaTemporal += 2
        '            End If
        '        ElseIf Not dosMilDetectado Or dosMilDetectado Then
        '            ' Tratar otras palabras si "dos mil" no ha sido detectado
        '            Select Case palabras(i)
        '                'Case "dos mil"
        '                '    sumaTemporal += 2000
        '                Case "mil"
        '                    If sumaTemporal <> 2000 Then
        '                        sumaTemporal += 1000
        '                    End If
        '                Case "novecientos"
        '                    sumaTemporal += 900
        '                Case "diez"
        '                    sumaTemporal += 10
        '                Case "once"
        '                    sumaTemporal += 11
        '                Case "doce"
        '                    sumaTemporal += 12
        '                Case "trece"
        '                    sumaTemporal += 13
        '                Case "catorce"
        '                    sumaTemporal += 14
        '                Case "quince"
        '                    sumaTemporal += 15
        '                Case "dieciséis", "dieciseis"
        '                    sumaTemporal += 16
        '                Case "diecisiete"
        '                    sumaTemporal += 17
        '                Case "dieciocho"
        '                    sumaTemporal += 18
        '                Case "diecinueve"
        '                    sumaTemporal += 19
        '                Case "veinte"
        '                    sumaTemporal += 20
        '                Case "veintiuno"
        '                    sumaTemporal += 21
        '                Case "veintidós", "veintidos"
        '                    sumaTemporal += 22
        '                Case "veintitrés", "veintitres"
        '                    sumaTemporal += 23
        '                Case "veinticuatro"
        '                    sumaTemporal += 24
        '                Case "veinticinco"
        '                    sumaTemporal += 25
        '                Case "veintiséis", "veintiseis"
        '                    sumaTemporal += 26
        '                Case "veintisiete"
        '                    sumaTemporal += 27
        '                Case "veintiocho"
        '                    sumaTemporal += 28
        '                Case "veintinueve"
        '                    sumaTemporal += 29
        '                Case "treinta"
        '                    sumaTemporal += 30
        '' Agrega las opciones para números con tilde
        '                Case "treinta y uno", "treintaiuno"
        '                    sumaTemporal += 31
        '                Case "treinta y dos", "treintaidos", "treintaidós"
        '                    sumaTemporal += 32
        '                Case "treinta y tres", "treintaitres", "treintaitrés"
        '                    sumaTemporal += 33
        '                Case "treinta y cuatro", "treintaicuatro"
        '                    sumaTemporal += 34
        '                Case "treinta y cinco", "treintaicinco"
        '                    sumaTemporal += 35
        '                Case "treinta y seis", "treintaiseis", "treintaiséis"
        '                    sumaTemporal += 36
        '                Case "treinta y siete", "treintaisiete"
        '                    sumaTemporal += 37
        '                Case "treinta y ocho", "treintaiocho"
        '                    sumaTemporal += 38
        '                Case "treinta y nueve", "treintainueve"
        '                    sumaTemporal += 39
        '                Case "cuarenta"
        '                    sumaTemporal += 40
        '                Case "cuarenta y uno", "cuarentaiuno"
        '                    sumaTemporal += 41
        '                Case "cuarenta y dos", "cuarentaidos", "cuarentaidós"
        '                    sumaTemporal += 42
        '                Case "cuarenta y tres", "cuarentaitres", "cuarentaitrés"
        '                    sumaTemporal += 43
        '                Case "cuarenta y cuatro", "cuarentaicuatro"
        '                    sumaTemporal += 44
        '                Case "cuarenta y cinco", "cuarentaicinco"
        '                    sumaTemporal += 45
        '                Case "cuarenta y seis", "cuarentaiseis", "cuarentaiséis"
        '                    sumaTemporal += 46
        '                Case "cuarenta y siete", "cuarentaisiete"
        '                    sumaTemporal += 47
        '                Case "cuarenta y ocho", "cuarentaiocho"
        '                    sumaTemporal += 48
        '                Case "cuarenta y nueve", "cuarentainueve"
        '                    sumaTemporal += 49
        '                Case "cincuenta"
        '                    sumaTemporal += 50
        '                Case "cincuenta y uno", "cincuentaiuno"
        '                    sumaTemporal += 51
        '                Case "cincuenta y dos", "cincuentaidos", "cincuentaidós"
        '                    sumaTemporal += 52
        '                Case "cincuenta y tres", "cincuentaitres", "cincuentaitrés"
        '                    sumaTemporal += 53
        '                Case "cincuenta y cuatro", "cincuentaicuatro"
        '                    sumaTemporal += 54
        '                Case "cincuenta y cinco", "cincuentaicinco"
        '                    sumaTemporal += 55
        '                Case "cincuenta y seis", "cincuentaiseis", "cincuentaiséis"
        '                    sumaTemporal += 56
        '                Case "cincuenta y siete", "cincuentaisiete"
        '                    sumaTemporal += 57
        '                Case "cincuenta y ocho", "cincuentaiocho"
        '                    sumaTemporal += 58
        '                Case "cincuenta y nueve", "cincuentainueve"
        '                    sumaTemporal += 59
        '                Case "sesenta"
        '                    sumaTemporal += 60
        '                Case "sesenta y uno", "sesentaiuno"
        '                    sumaTemporal += 61
        '                Case "sesenta y dos", "sesentaidos", "sesentaidós"
        '                    sumaTemporal += 62
        '                Case "sesenta y tres", "sesentaitres", "sesentaitrés"
        '                    sumaTemporal += 63
        '                Case "sesenta y cuatro", "sesentaicuatro"
        '                    sumaTemporal += 64
        '                Case "sesenta y cinco", "sesentaicinco"
        '                    sumaTemporal += 65
        '                Case "sesenta y seis", "sesentaiseis", "sesentaiséis"
        '                    sumaTemporal += 66
        '                Case "sesenta y siete", "sesentaisiete"
        '                    sumaTemporal += 67
        '                Case "sesenta y ocho", "sesentaiocho"
        '                    sumaTemporal += 68
        '                Case "sesenta y nueve", "sesentainueve"
        '                    sumaTemporal += 69
        '                Case "setenta"
        '                    sumaTemporal += 70
        '                Case "setenta y uno", "setentaiuno"
        '                    sumaTemporal += 71
        '                Case "setenta y dos", "setentaidos", "setentaidós"
        '                    sumaTemporal += 72
        '                Case "setenta y tres", "setentaitres", "setentaitrés"
        '                    sumaTemporal += 73
        '                Case "setenta y cuatro", "setentaicuatro"
        '                    sumaTemporal += 74
        '                Case "setenta y cinco", "setentaicinco"
        '                    sumaTemporal += 75
        '                Case "setenta y seis", "setentaiseis", "setentaiséis"
        '                    sumaTemporal += 76
        '                Case "setenta y siete", "setentaisiete"
        '                    sumaTemporal += 77
        '                Case "setenta y ocho", "setentaiocho"
        '                    sumaTemporal += 78
        '                Case "setenta y nueve", "setentainueve"
        '                    sumaTemporal += 79
        '                Case "ochenta"
        '                    sumaTemporal += 80
        '                Case "ochenta y uno", "ochentaiuno"
        '                    sumaTemporal += 81
        '                Case "ochenta y dos", "ochentaidos", "ochentaidós"
        '                    sumaTemporal += 82
        '                Case "ochenta y tres", "ochentaitres", "ochentaitrés"
        '                    sumaTemporal += 83
        '                Case "ochenta y cuatro", "ochentaicuatro"
        '                    sumaTemporal += 84
        '                Case "ochenta y cinco", "ochentaicinco"
        '                    sumaTemporal += 85
        '                Case "ochenta y seis", "ochentaiseis", "ochentaiséis"
        '                    sumaTemporal += 86
        '                Case "ochenta y siete", "ochentaisiete"
        '                    sumaTemporal += 87
        '                Case "ochenta y ocho", "ochentaiocho"
        '                    sumaTemporal += 88
        '                Case "ochenta y nueve", "ochentainueve"
        '                    sumaTemporal += 89
        '                Case "noventa"
        '                    sumaTemporal += 90
        '                Case "noventa y uno", "noventaiuno"
        '                    sumaTemporal += 91
        '                Case "noventa y dos", "noventaidos", "noventaidós"
        '                    sumaTemporal += 92
        '                Case "noventa y tres", "noventaitres", "noventaitrés"
        '                    sumaTemporal += 93
        '                Case "noventa y cuatro", "noventaicuatro"
        '                    sumaTemporal += 94
        '                Case "noventa y cinco", "noventaicinco"
        '                    sumaTemporal += 95
        '                Case "noventa y seis", "noventaiseis", "noventaiséis"
        '                    sumaTemporal += 96
        '                Case "noventa y siete", "noventaisiete"
        '                    sumaTemporal += 97
        '                Case "noventa y ocho", "noventaiocho"
        '                    sumaTemporal += 98
        '                Case "noventa y nueve", "noventainueve"
        '                    sumaTemporal += 99
        '                Case "uno"
        '                    sumaTemporal += 1
        '                Case "dos"
        '                    sumaTemporal += 2
        '                Case "tres"
        '                    sumaTemporal += 3
        '                Case "cuatro"
        '                    sumaTemporal += 4
        '                Case "cinco"
        '                    sumaTemporal += 5
        '                Case "seis"
        '                    sumaTemporal += 6
        '                Case "siete"
        '                    sumaTemporal += 7
        '                Case "ocho"
        '                    sumaTemporal += 8
        '                Case "nueve"
        '                    sumaTemporal += 9
        '                Case Else
        '                    Dim valor As Integer = 0

        '                    ' Intentar analizar la palabra actual como número
        '                    If Integer.TryParse(palabras(i), valor) Then
        '                        sumaTemporal += valor
        '                    ElseIf palabras(i) = "y" Then
        '                        ' Ignorar el "y" y continuar analizando la siguiente palabra
        '                    ElseIf i < palabras.Length - 1 AndAlso Integer.TryParse(palabras(i + 1), valor) Then
        '                        ' Verificar si la siguiente palabra es un número
        '                        sumaTemporal += valor
        '                        i += 1 ' Saltar la siguiente palabra
        '                    End If
        '            End Select
        '        Else
        '            ' Si "dos mil" ya fue detectado, tratar el resto de las palabras
        '            Dim valor As Integer = 0

        '            ' Intentar analizar la palabra actual como número
        '            If Integer.TryParse(palabras(i), valor) Then
        '                sumaTemporal += valor
        '            End If
        '        End If
        '    Next

        '    resultado += sumaTemporal

        '    Return resultado
    End Function

    Private Sub FeDeBautismoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeDeBautismoToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim feDeBautismo As New InformacionFeDeBautismo()

        ' Mostrar el formulario Form2
        feDeBautismo.Show()
        'Me.Close()
    End Sub

    Private Sub ActaDeMatrimonioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActaDeMatrimonioToolStripMenuItem.Click
        ' Crear una instancia del formulario Form2
        Dim actaMatrimonio As New InformacionActaDeMatrimonio()

        ' Mostrar el formulario Form2
        actaMatrimonio.Show()
        'Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim actaDeConfirmación As New InformacionActaDeConfirmacion()

        ' Mostrar el formulario Form2
        actaDeConfirmación.Show()
        'Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Crear una instancia del formulario Form2
        Dim feDeBautismo As New InformacionFeDeBautismo()

        ' Mostrar el formulario Form2
        feDeBautismo.Show()
        'Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Crear una instancia del formulario Form2
        Dim actaMatrimonio As New InformacionActaDeMatrimonio()

        ' Mostrar el formulario Form2
        actaMatrimonio.Show()
        'Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
