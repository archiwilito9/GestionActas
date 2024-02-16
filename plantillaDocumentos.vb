Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Word

Module plantillaDocumentos
    Public Sub CrearActaConfirma(libro As String, pagina As String, asiento As String, fechaSacramentoConfirma As DateTime, administrador As String, generoConfrimado As RadioButton, nombre As String, departamento As String, fechaNacimiento As DateTime, padreConfirmado As RadioButton, nombreMadre As String, nombrePadre As String, padrinoConfirmado As RadioButton, nombrePadrino As String, fechaExtension As DateTime)
        Try
            ' Cargar el archivo XML
            'Dim docXML As XDocument = XDocument.Load("Base de datos.xml")
            ' Conexión a la base de datos
            Dim conexion As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")

            ' Consulta SQL para insertar datos en la tabla "Confirma"
            Dim consulta As String = "INSERT INTO Confirma (numLibroConfirma, numPaginaConfirma, numAsientoConfirma, fechaAdministracionSacramento, administradorSacramento, generoConfirmado, nombreConfirmado, departamentoNacimiento, fechaNacimientoConfirmado, padreConfirmado, nombreMadre, nombrePadre, padrinoConfirmado, nombrePadrinos, fechaExtensionConfirma, id_tipoActa) VALUES (@numLibro, @numPagina, @numAsiento, @fechaSacramento, @administrador, @generoConfirmado, @nombre, @departamento, @fechaNacimiento, @padreConfirmado, @nombreMadre, @nombrePadre, @padrinoConfirmado, @nombrePadrinos, @fechaExtension,1)"

            ' Crear el comando SQL
            Dim comando As New SqlCommand(consulta, conexion)

            ' Establecer los valores de los parámetros en la consulta
            comando.Parameters.AddWithValue("@numLibro", libro)
            comando.Parameters.AddWithValue("@numPagina", pagina)
            comando.Parameters.AddWithValue("@numAsiento", asiento)
            comando.Parameters.AddWithValue("@fechaSacramento", fechaSacramentoConfirma)
            comando.Parameters.AddWithValue("@administrador", administrador)
            comando.Parameters.AddWithValue("@generoConfirmado", generoConfrimado.Text) ' Asegúrate de usar el valor correcto del RadioButton
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@departamento", departamento)
            comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
            comando.Parameters.AddWithValue("@padreConfirmado", padreConfirmado.Text)
            comando.Parameters.AddWithValue("@nombreMadre", nombreMadre)
            comando.Parameters.AddWithValue("@nombrePadre", nombrePadre)
            comando.Parameters.AddWithValue("@padrinoConfirmado", padrinoConfirmado.Text) ' Asegúrate de usar el valor correcto del RadioButton
            comando.Parameters.AddWithValue("@nombrePadrinos", nombrePadrino)
            comando.Parameters.AddWithValue("@fechaExtension", fechaExtension)

            ' Abrir la conexión y ejecutar la consulta
            conexion.Open()
            comando.ExecuteNonQuery()

            ' Cerrar la conexión
            conexion.Close()

            ' Realizar las acciones necesarias después de la inserción
            ' Por ejemplo, mostrar un mensaje de éxito o limpiar los campos del formulario.
            MessageBox.Show("Los datos se han ingresado correctamente.")

        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir durante la inserción de datos.
            ' Puedes mostrar un mensaje de error o realizar alguna otra acción de manejo de errores.
            MessageBox.Show("Error al insertar los datos: " & ex.Message)
        End Try
    End Sub

    Public Sub CrearFeBautismo(libro As String, pagina As String, asiento As String, fechaSacramentoFeBautismo As DateTime, administradorBautizo As String, generoBautizado As RadioButton, nombre As String, departamento As String, fechaNacimiento As DateTime, padreBautizado As RadioButton, nombreMadre As String, nombrePadre As String, padrinoBautizado As RadioButton, nombrePadrino As String, fechaExtension As DateTime)
        Try
            ' Conexión a la base de datos
            Dim conexion As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")

            ' Consulta SQL para insertar datos en la tabla "Confirma"
            Dim consulta As String = "INSERT INTO Bautismo (numLibroBautismo, numPaginaBautismo, numAsientoBautismo, fechaAdministracionSacramento, administradorSacramento, generoBautizado, nombreBautizado, departamentoNacimiento, fechaNacimientoBautizado, padreBautizado, nombreMadre, nombrePadre, padrinoBautizado, nombrePadrinos, fechaExtensionBautismo, id_tipoActa) VALUES (@numLibro, @numPagina, @numAsiento, @fechaSacramento, @administrador, @generoConfirmado, @nombre, @departamento, @fechaNacimiento, @padreConfirmado, @nombreMadre, @nombrePadre, @padrinoConfirmado, @nombrePadrinos, @fechaExtension,2)"

            ' Crear el comando SQL
            Dim comando As New SqlCommand(consulta, conexion)

            ' Establecer los valores de los parámetros en la consulta
            comando.Parameters.AddWithValue("@numLibro", libro)
            comando.Parameters.AddWithValue("@numPagina", pagina)
            comando.Parameters.AddWithValue("@numAsiento", asiento)
            comando.Parameters.AddWithValue("@fechaSacramento", fechaSacramentoFeBautismo)
            comando.Parameters.AddWithValue("@administrador", administradorBautizo)
            comando.Parameters.AddWithValue("@generoConfirmado", generoBautizado.Text) ' Asegúrate de usar el valor correcto del RadioButton
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@departamento", departamento)
            comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
            comando.Parameters.AddWithValue("@padreConfirmado", padreBautizado.Text)
            comando.Parameters.AddWithValue("@nombreMadre", nombreMadre)
            comando.Parameters.AddWithValue("@nombrePadre", nombrePadre)
            comando.Parameters.AddWithValue("@padrinoConfirmado", padrinoBautizado.Text) ' Asegúrate de usar el valor correcto del RadioButton
            comando.Parameters.AddWithValue("@nombrePadrinos", nombrePadrino)
            comando.Parameters.AddWithValue("@fechaExtension", fechaExtension)

            ' Abrir la conexión y ejecutar la consulta
            conexion.Open()
            comando.ExecuteNonQuery()

            ' Cerrar la conexión
            conexion.Close()

            MessageBox.Show("Los datos se han ingresado correctamente.")

            ' Realizar las acciones necesarias después de la inserción
            ' Por ejemplo, mostrar un mensaje de éxito o limpiar los campos del formulario.

        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir durante la inserción de datos.
            ' Puedes mostrar un mensaje de error o realizar alguna otra acción de manejo de errores.
            MessageBox.Show("Error al insertar los datos: " & ex.Message)
        End Try
    End Sub

    Public Sub CrearActaMatrimonio(libro As String, acta As String, fechaBendicionMatrimonio As DateTime, administradorMatrimonio As String, nombreNovio As String, edadNovio As String, padresNovio As RadioButton, nombrePadreNovio As String, nombreMadreNovio As String, departamentoNovio As String, nombreNovia As String, edadNovia As String, padresNovia As RadioButton, nombrePadreNovia As String, nombreMadreNovia As String, departamentoNovia As String, padrinoMatrimonio As RadioButton, nombrePadrino As String, fechaExtension As DateTime)
        Try
            ' Conexión a la base de datos
            Dim conexion As New SqlConnection("server=WILITO-COMPUTER\MARVINTOBAR;database=actasParroquia;integrated security=true")

            ' Consulta SQL para insertar datos en la tabla "Confirma"
            Dim consulta As String = "INSERT INTO Matrimonio (numLibroMatrimonio, numActaMatrimonio, fechaBendicionMatrimonio, administradorMatrimonio, nombreNovio, edadNovio, padresNovio, nombrePadreNovio, nombreMadreNovio, departamentoNovio, nombreNovia, edadNovia, padresNovia, nombrePadreNovia, nombreMadreNovia, departamentoNovia, padrinoMatrimonio, nombrePadrino, fechaExtension, id_tipoActa) VALUES (@numLibroMatrimonio, @numActaMatrimonio, @fechaBendicionMatrimonio, @administradorMatrimonio, @nombreNovio, @edadNovio, @padresNovio, @nombrePadreNovio, @nombreMadreNovio, @departamentoNovio, @nombreNovia, @edadNovia, @padresNovia, @nombrePadreNovia, @nombreMadreNovia, @departamentoNovia, @padrinoMatrimonio, @nombrePadrino, @fechaExtension, 3)"

            ' Crear el comando SQL
            Dim comando As New SqlCommand(consulta, conexion)

            ' Establecer los valores de los parámetros en la consulta
            ' Establecer los valores de los parámetros en la consulta
            comando.Parameters.AddWithValue("@numLibroMatrimonio", libro)
            comando.Parameters.AddWithValue("@numActaMatrimonio", acta)
            comando.Parameters.AddWithValue("@fechaBendicionMatrimonio", fechaBendicionMatrimonio)
            comando.Parameters.AddWithValue("@administradorMatrimonio", administradorMatrimonio)
            comando.Parameters.AddWithValue("@nombreNovio", nombreNovio)
            comando.Parameters.AddWithValue("@edadNovio", edadNovio) ' Asegúrate de tener el valor correcto
            comando.Parameters.AddWithValue("@padresNovio", padresNovio.Text)
            comando.Parameters.AddWithValue("@nombrePadreNovio", nombrePadreNovio)
            comando.Parameters.AddWithValue("@nombreMadreNovio", nombreMadreNovio)
            comando.Parameters.AddWithValue("@departamentoNovio", departamentoNovio)
            comando.Parameters.AddWithValue("@nombreNovia", nombreNovia)
            comando.Parameters.AddWithValue("@edadNovia", edadNovia) ' Asegúrate de tener el valor correcto
            comando.Parameters.AddWithValue("@padresNovia", padresNovia.Text)
            comando.Parameters.AddWithValue("@nombrePadreNovia", nombrePadreNovia)
            comando.Parameters.AddWithValue("@nombreMadreNovia", nombreMadreNovia)
            comando.Parameters.AddWithValue("@departamentoNovia", departamentoNovia)
            comando.Parameters.AddWithValue("@padrinoMatrimonio", padrinoMatrimonio.Text)
            comando.Parameters.AddWithValue("@nombrePadrino", nombrePadrino)
            comando.Parameters.AddWithValue("@fechaExtension", fechaExtension)

            ' Abrir la conexión y ejecutar la consulta
            conexion.Open()
            comando.ExecuteNonQuery()

            ' Cerrar la conexión
            conexion.Close()
            MessageBox.Show("Los datos se han ingresado correctamente.")

            ' Realizar las acciones necesarias después de la inserción
            ' Por ejemplo, mostrar un mensaje de éxito o limpiar los campos del formulario.

        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir durante la inserción de datos.
            ' Puedes mostrar un mensaje de error o realizar alguna otra acción de manejo de errores.
            MessageBox.Show("Error al insertar los datos: " & ex.Message)
        End Try
    End Sub

    Public Sub CrearActaConfirma(libro As String, pagina As String, asiento As String, fechaSacramentoConfirma As DateTime, administrador As String, generoConfrimado As String, nombre As String, departamento As String, fechaNacimiento As DateTime, padreConfirmado As String, nombreMadre As String, nombrePadre As String, padrinoConfirmado As String, nombrePadrino As String, fechaExtension As DateTime)
        ' Crear una instancia de la aplicación Word
        Dim wordApp As New Application()
        wordApp.Visible = True ' Para mostrar la aplicación Word
        ' Crear un nuevo documento
        Dim doc As Document = wordApp.Documents.Add()
        ' Establecer el tamaño de página a Legal (22x36 cm o 8.5''x11'')
        doc.PageSetup.PaperSize = WdPaperSize.wdPaperLegal
        ' Establecer los márgenes (izquierda 3.5 cm, derecha 2.86 cm, arriba 0.63 cm, abajo 1.17 cm)
        doc.PageSetup.LeftMargin = cmAPuntos(3.5) ' 3.5 cm
        doc.PageSetup.RightMargin = cmAPuntos(0.5) ' 2.86 cm
        doc.PageSetup.TopMargin = cmAPuntos(0.5) ' 0.63 cm
        doc.PageSetup.BottomMargin = cmAPuntos(1.17) ' 1.17 cm
        ' Establecer el formato para cabecera
        Dim cabeceraRange As Range = doc.Content.Paragraphs.Add().Range
        cabeceraRange.Text = vbTab & vbTab & "PARROQUIA NUESTRA SEÑORA DE LA PAZ" & vbCrLf
        cabeceraRange.Font.Name = "Monotype Corsiva"
        cabeceraRange.Font.Size = 18
        cabeceraRange.Font.Bold = 1
        cabeceraRange.Font.Underline = WdUnderline.wdUnderlineNone
        cabeceraRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Establecer el interlineado entre párrafos a 1.0 (equivalente a 14 puntos en el espacio de línea)
        cabeceraRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        cabeceraRange.ParagraphFormat.LineSpacing = 14
        cabeceraRange.ParagraphFormat.SpaceAfter = 0
        cabeceraRange.ParagraphFormat.SpaceBefore = 22
        Dim cabeceraTextoRange As Range = doc.Content.Paragraphs.Add().Range
        cabeceraTextoRange.Text = vbTab & vbTab & "Residencial Bosques de Paz. Calle Los Abetos, Calle 15 Ote. " & vbCrLf & vbTab & vbTab & " Y Avenida Los Cipreses; Ilopango Teléfono 2294 3472" & vbCrLf &
            vbTab & vbTab & "email   parroquiabosquesdelapaz@yahoo.com" & vbCrLf &
            vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        cabeceraTextoRange.Font.Name = "Monotype Corsiva"
        cabeceraTextoRange.Font.Size = 14
        cabeceraTextoRange.Font.Bold = 0
        cabeceraTextoRange.Font.Underline = WdUnderline.wdUnderlineNone
        cabeceraTextoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Establecer el interlineado entre párrafos a 1.0 (equivalente a 14 puntos en el espacio de línea)
        cabeceraTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        cabeceraTextoRange.ParagraphFormat.LineSpacing = 14
        cabeceraTextoRange.ParagraphFormat.SpaceAfter = 0
        ' Establecer el formato para "ACTA DE CONFIRMACIÓN"
        Dim tituloRange As Range = doc.Content.Paragraphs.Add().Range
        tituloRange.Text = "ACTA DE CONFIRMACIÓN" & vbCrLf ' Agregar el título
        tituloRange.Font.Name = "Arial"
        tituloRange.Font.Size = 14
        tituloRange.Font.Bold = 1
        tituloRange.Font.Underline = WdUnderline.wdUnderlineSingle
        tituloRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Agregar un salto de sección continuo
        tituloRange.InsertBreak(Type:=WdBreakType.wdSectionBreakContinuous)
        Dim seccionNueva As Section = doc.Sections(2)
        seccionNueva.PageSetup.LeftMargin = cmAPuntos(3) ' Nuevos márgenes izquierdos
        seccionNueva.PageSetup.RightMargin = cmAPuntos(3) ' Nuevos márgenes derechos
        seccionNueva.PageSetup.TopMargin = cmAPuntos(0.63) ' Nuevos márgenes superiores
        seccionNueva.PageSetup.BottomMargin = cmAPuntos(1.17) ' Nuevos márgenes inferiores
        ' Restablecer el formato para el resto del texto
        Dim cuerpoRange As Range = doc.Content.Paragraphs.Add().Range
        cuerpoRange.Font.Name = "Arial"
        cuerpoRange.Font.Size = 14
        cuerpoRange.Font.Bold = 0
        cuerpoRange.Font.Underline = WdUnderline.wdUnderlineNone
        cuerpoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
        Dim diaConfirma As String = annioALetra(fechaSacramentoConfirma.Day).Trim()
        If diaConfirma = "uno" Then
            diaConfirma = "un"
        End If
        If diaConfirma = "veintiuno" Then
            diaConfirma = "veintiún"
        End If
        If diaConfirma = "treinta y uno" Then
            diaConfirma = "treinta y un"
        End If
        If diaConfirma = "un" Then
            cuerpoRange.Text = "En la Parroquia Nuestra Señora de La Paz, en Residencial Bosques de la Paz, en el municipio de Ilopango, San Salvador se CERTIFICA QUE: en el libro de confirmas de este archivo Parroquial Libro " & libro.Trim() & ", página " & pagina.Trim() & ", asiento, " & asiento.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "A " & diaConfirma & " día del mes de " & MonthName(fechaSacramentoConfirma.Month).Trim() & " del año " & annioALetra(fechaSacramentoConfirma.Year).Trim() & " " & administrador.Trim() & " administró el sacramento de la confirmación a: " & nombre.Trim() & ", que nació en " & departamento.Trim() & " el día " & annioALetra(fechaNacimiento.Day).Trim() & " de " & MonthName(fechaNacimiento.Month).Trim() & " del año " & annioALetra(fechaNacimiento.Year).Trim()
        Else
            cuerpoRange.Text = "En la Parroquia Nuestra Señora de La Paz, en Residencial Bosques de la Paz, en el municipio de Ilopango, San Salvador se CERTIFICA QUE: en el libro de confirmas de este archivo Parroquial Libro " & libro.Trim() & ", página " & pagina.Trim() & ", asiento, " & asiento.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "A " & diaConfirma & " días del mes de " & MonthName(fechaSacramentoConfirma.Month).Trim() & " del año " & annioALetra(fechaSacramentoConfirma.Year).Trim() & " " & administrador.Trim() & " administró el sacramento de la confirmación a: " & nombre.Trim() & ", que nació en " & departamento.Trim() & " el día " & annioALetra(fechaNacimiento.Day).Trim() & " de " & MonthName(fechaNacimiento.Month).Trim() & " del año " & annioALetra(fechaNacimiento.Year).Trim()
        End If
        'GENERO
        If generoConfrimado = "Masculino" Then
            cuerpoRange.Text = cuerpoRange.Text & ", hijo de "
        End If
        If generoConfrimado = "Femenino" Then
            cuerpoRange.Text = cuerpoRange.Text & ", hija de "
        End If
        'PADRE
        If padreConfirmado = "Ambos padres" Then
            cuerpoRange.Text = cuerpoRange.Text & nombrePadre.Trim() & " y de " & nombreMadre.Trim()
        End If
        If padreConfirmado = "Solo madre" Then
            cuerpoRange.Text = cuerpoRange.Text & nombreMadre.Trim()
        End If
        If padreConfirmado = "Solo padre" Then
            cuerpoRange.Text = cuerpoRange.Text & nombrePadre.Trim()
        End If
        Dim diaExtension As String = annioALetra(fechaExtension.Day).Trim()
        If diaExtension = "uno" Then
            diaExtension = "un"
        End If
        If diaExtension = "veintiuno" Then
            diaExtension = "veintiún"
        End If
        If diaExtension = "treinta y uno" Then
            diaExtension = "treinta y un"
        End If
        If diaExtension = "un" Then
            'PADRINO
            If padrinoConfirmado = "Padrino" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue padrino: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para uso que el interesado estime conveniente se extiende la presente acta de confirmación a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MADRINA
            If padrinoConfirmado = "Madrina" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue madrina: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para uso que el interesado estime conveniente se extiende la presente acta de confirmación a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MÚLTIPLES PADRINOS
            If padrinoConfirmado = "Múltiples padrinos" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fueron padrinos: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para uso que el interesado estime conveniente se extiende la presente acta de confirmación a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
        Else
            'PADRINO
            If padrinoConfirmado = "Padrino" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue padrino: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para uso que el interesado estime conveniente se extiende la presente acta de confirmación a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MADRINA
            If padrinoConfirmado = "Madrina" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue madrina: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para uso que el interesado estime conveniente se extiende la presente acta de confirmación a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MÚLTIPLES PADRINOS
            If padrinoConfirmado = "Múltiples padrinos" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fueron padrinos: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para uso que el interesado estime conveniente se extiende la presente acta de confirmación a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
        End If
        ' Restablecer el formato para el resto del texto
        Dim finalRange As Range = doc.Content.Paragraphs.Add().Range
        finalRange.Font.Name = "Arial"
        finalRange.Font.Size = 14
        finalRange.Font.Bold = 0
        finalRange.Font.Underline = WdUnderline.wdUnderlineNone
        finalRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter

        ' Agregar el resto del texto
        finalRange.Text = vbTab & vbTab & vbTab & vbTab & vbTab & "Pbro. Francisco Javier Morán Martínez" & vbCrLf
        finalRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        finalRange.ParagraphFormat.SpaceAfter = 0
        Dim finalTextoRange As Range = doc.Content.Paragraphs.Add().Range
        finalTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        finalTextoRange.Text = vbTab & vbTab & vbTab & vbTab & vbTab & "Párroco"
        finalTextoRange.Font.Name = "Arial"
        finalTextoRange.Font.Size = 14
        finalTextoRange.Font.Bold = 0
        finalTextoRange.Font.Underline = WdUnderline.wdUnderlineNone
        finalTextoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        'finalTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly

        finalTextoRange.ParagraphFormat.LineSpacing = 12
        finalTextoRange.ParagraphFormat.SpaceAfter = 0
        finalTextoRange.ParagraphFormat.SpaceBefore = 0

        ' Liberar recursos
        System.Runtime.InteropServices.Marshal.ReleaseComObject(doc)
    End Sub

    Public Sub CrearFeBautismo(libro As String, pagina As String, asiento As String, fechaSacramentoFeBautismo As DateTime, administradorBautizo As String, generoBautizado As String, nombre As String, departamento As String, fechaNacimiento As DateTime, padreBautizado As String, nombreMadre As String, nombrePadre As String, padrinoBautizado As String, nombrePadrino As String, fechaExtension As DateTime)
        ' Crear una instancia de la aplicación Word
        Dim wordApp As New Application()
        wordApp.Visible = True ' Para mostrar la aplicación Word
        ' Crear un nuevo documento
        Dim doc As Document = wordApp.Documents.Add()
        ' Establecer el tamaño de página a Legal (22x36 cm o 8.5''x11'')
        doc.PageSetup.PaperSize = WdPaperSize.wdPaperLegal
        ' Establecer los márgenes (izquierda 3.5 cm, derecha 2.86 cm, arriba 0.63 cm, abajo 1.17 cm)
        doc.PageSetup.LeftMargin = cmAPuntos(3.5) ' 3.5 cm
        doc.PageSetup.RightMargin = cmAPuntos(0.5) ' 2.86 cm
        doc.PageSetup.TopMargin = cmAPuntos(0.5) ' 0.63 cm
        doc.PageSetup.BottomMargin = cmAPuntos(1.17) ' 1.17 cm
        ' Establecer el formato para cabecera
        Dim cabeceraRange As Range = doc.Content.Paragraphs.Add().Range
        cabeceraRange.Text = vbTab & vbTab & "PARROQUIA NUESTRA SEÑORA DE LA PAZ" & vbCrLf
        cabeceraRange.Font.Name = "Monotype Corsiva"
        cabeceraRange.Font.Size = 18
        cabeceraRange.Font.Bold = 1
        cabeceraRange.Font.Underline = WdUnderline.wdUnderlineNone
        cabeceraRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Establecer el interlineado entre párrafos a 1.0 (equivalente a 14 puntos en el espacio de línea)
        cabeceraRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        cabeceraRange.ParagraphFormat.LineSpacing = 14
        cabeceraRange.ParagraphFormat.SpaceAfter = 0
        cabeceraRange.ParagraphFormat.SpaceBefore = 22
        Dim cabeceraTextoRange As Range = doc.Content.Paragraphs.Add().Range
        cabeceraTextoRange.Text = vbTab & vbTab & "Residencial Bosques de Paz. Calle Los Abetos, Calle 15 Ote. " & vbCrLf & vbTab & vbTab & " Y Avenida Los Cipreses; Ilopango Teléfono 2294 3472" & vbCrLf &
            vbTab & vbTab & "email   parroquiabosquesdelapaz@yahoo.com" & vbCrLf &
            vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        cabeceraTextoRange.Font.Name = "Monotype Corsiva"
        cabeceraTextoRange.Font.Size = 14
        cabeceraTextoRange.Font.Bold = 0
        cabeceraTextoRange.Font.Underline = WdUnderline.wdUnderlineNone
        cabeceraTextoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Establecer el interlineado entre párrafos a 1.0 (equivalente a 14 puntos en el espacio de línea)
        cabeceraTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        cabeceraTextoRange.ParagraphFormat.LineSpacing = 14
        cabeceraTextoRange.ParagraphFormat.SpaceAfter = 0
        ' Establecer el formato para "ACTA DE CONFIRMACIÓN"
        Dim tituloRange As Range = doc.Content.Paragraphs.Add().Range
        tituloRange.Text = "FE DE BAUTISMO" & vbCrLf ' Agregar el título
        tituloRange.Font.Name = "Arial"
        tituloRange.Font.Size = 14
        tituloRange.Font.Bold = 1
        tituloRange.Font.Underline = WdUnderline.wdUnderlineSingle
        tituloRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Agregar un salto de sección continuo
        tituloRange.InsertBreak(Type:=WdBreakType.wdSectionBreakContinuous)
        Dim seccionNueva As Section = doc.Sections(2)
        seccionNueva.PageSetup.LeftMargin = cmAPuntos(3) ' Nuevos márgenes izquierdos
        seccionNueva.PageSetup.RightMargin = cmAPuntos(3) ' Nuevos márgenes derechos
        seccionNueva.PageSetup.TopMargin = cmAPuntos(0.63) ' Nuevos márgenes superiores
        seccionNueva.PageSetup.BottomMargin = cmAPuntos(1.17) ' Nuevos márgenes inferiores
        ' Restablecer el formato para el resto del texto
        Dim cuerpoRange As Range = doc.Content.Paragraphs.Add().Range
        cuerpoRange.Font.Name = "Arial"
        cuerpoRange.Font.Size = 14
        cuerpoRange.Font.Bold = 0
        cuerpoRange.Font.Underline = WdUnderline.wdUnderlineNone
        cuerpoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
        ' Agregar el resto del texto
        Dim diaBautismo As String = annioALetra(fechaSacramentoFeBautismo.Day).Trim()
        If diaBautismo = "uno" Then
            diaBautismo = "un"
        End If
        If diaBautismo = "veintiuno" Then
            diaBautismo = "veintiún"
        End If
        If diaBautismo = "treinta y uno" Then
            diaBautismo = "treinta y un"
        End If
        If diaBautismo = "un" Then
            cuerpoRange.Text = "El infrascrito párroco de la parroquia ""NUESTRA SEÑORA DE LA PAZ"", en Residencial Bosques de la Paz, municipio de Ilopango, San Salvador se CERTIFICA QUE: en el libro de partidas de bautizos de este archivo parroquial Libro " & libro.Trim() & ", página No. " & pagina.Trim() & ", asiento No " & asiento.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "A " & diaBautismo & " día del mes de " & MonthName(fechaSacramentoFeBautismo.Month).Trim() & " del año " & annioALetra(fechaSacramentoFeBautismo.Year).Trim() & " el " & administradorBautizo.Trim() & " BAUTIZÓ SOLEMNEMENTE A:  " & nombre.Trim() & ", que nació en " & departamento.Trim() & " el día " & annioALetra(fechaNacimiento.Day).Trim() & " de " & MonthName(fechaNacimiento.Month).Trim() & " del año " & annioALetra(fechaNacimiento.Year).Trim()
        Else
            cuerpoRange.Text = "El infrascrito párroco de la parroquia ""NUESTRA SEÑORA DE LA PAZ"", en Residencial Bosques de la Paz, municipio de Ilopango, San Salvador se CERTIFICA QUE: en el libro de partidas de bautizos de este archivo parroquial Libro " & libro.Trim() & ", página No. " & pagina.Trim() & ", asiento No " & asiento.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "A " & diaBautismo & " días del mes de " & MonthName(fechaSacramentoFeBautismo.Month).Trim() & " del año " & annioALetra(fechaSacramentoFeBautismo.Year).Trim() & " el " & administradorBautizo.Trim() & " BAUTIZÓ SOLEMNEMENTE A:  " & nombre.Trim() & ", que nació en " & departamento.Trim() & " el día " & annioALetra(fechaNacimiento.Day).Trim() & " de " & MonthName(fechaNacimiento.Month).Trim() & " del año " & annioALetra(fechaNacimiento.Year).Trim()
        End If
        'GENERO
        If generoBautizado = "Masculino" Then
            cuerpoRange.Text = cuerpoRange.Text & ", hijo de "
        End If
        If generoBautizado = "Femenino" Then
            cuerpoRange.Text = cuerpoRange.Text & ", hija de "
        End If
        'PADRE
        If padreBautizado = "Ambos padres" Then
            cuerpoRange.Text = cuerpoRange.Text & nombrePadre.Trim() & " y de " & nombreMadre.Trim()
        End If
        If padreBautizado = "Solo madre" Then
            cuerpoRange.Text = cuerpoRange.Text & nombreMadre.Trim()
        End If
        If padreBautizado = "Solo padre" Then
            cuerpoRange.Text = cuerpoRange.Text & nombrePadre.Trim()
        End If
        Dim diaExtension As String = annioALetra(fechaExtension.Day).Trim()
        If diaExtension = "uno" Then
            diaExtension = "un"
        End If
        If diaExtension = "veintiuno" Then
            diaExtension = "veintiún"
        End If
        If diaExtension = "treinta y uno" Then
            diaExtension = "treinta y un"
        End If
        If diaExtension = "un" Then
            'PADRINO
            If padrinoBautizado = "Padrino" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue padrino: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para los usos que convengan, firmo y sello la presente en Ilopango a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MADRINA
            If padrinoBautizado = "Madrina" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue madrina: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para los usos que convengan, firmo y sello la presente en Ilopango a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MÚLTIPLES PADRINOS
            If padrinoBautizado = "Múltiples padrinos" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fueron padrinos: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para los usos que convengan, firmo y sello la presente en Ilopango a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
        Else
            'PADRINO
            If padrinoBautizado = "Padrino" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue padrino: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para los usos que convengan, firmo y sello la presente en Ilopango a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MADRINA
            If padrinoBautizado = "Madrina" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fue madrina: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para los usos que convengan, firmo y sello la presente en Ilopango a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
            'MÚLTIPLES PADRINOS
            If padrinoBautizado = "Múltiples padrinos" Then
                ' Agregar resto del texto
                cuerpoRange.Text = cuerpoRange.Text & ". Fueron padrinos: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf & "Y para los usos que convengan, firmo y sello la presente en Ilopango a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaExtension.Year).Trim() & "." & vbCrLf & vbCrLf & vbCrLf
            End If
        End If

        ' Restablecer el formato para el resto del texto
        ' Restablecer el formato para el resto del texto
        Dim finalRange As Range = doc.Content.Paragraphs.Add().Range
        finalRange.Font.Name = "Arial"
        finalRange.Font.Size = 14
        finalRange.Font.Bold = 0
        finalRange.Font.Underline = WdUnderline.wdUnderlineNone
        finalRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter

        ' Agregar el resto del texto
        finalRange.Text = vbTab & vbTab & vbTab & vbTab & vbTab & "Pbro. Francisco Javier Morán Martínez" & vbCrLf
        finalRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        finalRange.ParagraphFormat.SpaceAfter = 0
        Dim finalTextoRange As Range = doc.Content.Paragraphs.Add().Range
        finalTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        finalTextoRange.Text = vbTab & vbTab & vbTab & vbTab & vbTab & "Párroco"
        finalTextoRange.Font.Name = "Arial"
        finalTextoRange.Font.Size = 14
        finalTextoRange.Font.Bold = 0
        finalTextoRange.Font.Underline = WdUnderline.wdUnderlineNone
        finalTextoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        'finalTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly

        finalTextoRange.ParagraphFormat.LineSpacing = 12
        finalTextoRange.ParagraphFormat.SpaceAfter = 0
        finalTextoRange.ParagraphFormat.SpaceBefore = 0

        ' Dejar la aplicación Word abierta sin guardar el archivo
        ' Puedes cerrar manualmente la aplicación Word cuando hayas terminado.

        ' Liberar recursos
        System.Runtime.InteropServices.Marshal.ReleaseComObject(doc)
    End Sub

    Public Sub CrearActaMatrimonio(libro As String, acta As String, fechaBendicionMatrimonio As DateTime, administradorMatrimonio As String, nombreNovio As String, edadNovio As String, padresNovio As String, nombrePadreNovio As String, nombreMadreNovio As String, departamentoNovio As String, nombreNovia As String, edadNovia As String, padresNovia As String, nombrePadreNovia As String, nombreMadreNovia As String, departamentoNovia As String, padrinoMatrimonio As String, nombrePadrino As String, fechaExtension As DateTime)
        ' Crear una instancia de la aplicación Word
        Dim wordApp As New Application()
        wordApp.Visible = True ' Para mostrar la aplicación Word
        ' Crear un nuevo documento
        Dim doc As Document = wordApp.Documents.Add()
        ' Establecer el tamaño de página a Legal (22x36 cm o 8.5''x11'')
        doc.PageSetup.PaperSize = WdPaperSize.wdPaperLegal
        ' Establecer los márgenes (izquierda 3.5 cm, derecha 2.86 cm, arriba 0.63 cm, abajo 1.17 cm)
        doc.PageSetup.LeftMargin = cmAPuntos(3.5) ' 3.5 cm
        doc.PageSetup.RightMargin = cmAPuntos(0.5) ' 2.86 cm
        doc.PageSetup.TopMargin = cmAPuntos(0.5) ' 0.63 cm
        doc.PageSetup.BottomMargin = cmAPuntos(1.17) ' 1.17 cm
        ' Establecer el formato para cabecera
        Dim cabeceraRange As Range = doc.Content.Paragraphs.Add().Range
        cabeceraRange.Text = vbTab & vbTab & "PARROQUIA NUESTRA SEÑORA DE LA PAZ" & vbCrLf
        cabeceraRange.Font.Name = "Monotype Corsiva"
        cabeceraRange.Font.Size = 18
        cabeceraRange.Font.Bold = 1
        cabeceraRange.Font.Underline = WdUnderline.wdUnderlineNone
        cabeceraRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Establecer el interlineado entre párrafos a 1.0 (equivalente a 14 puntos en el espacio de línea)
        cabeceraRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        cabeceraRange.ParagraphFormat.LineSpacing = 14
        cabeceraRange.ParagraphFormat.SpaceAfter = 0
        cabeceraRange.ParagraphFormat.SpaceBefore = 22

        Dim cabeceraTextoRange As Range = doc.Content.Paragraphs.Add().Range
        cabeceraTextoRange.Text = vbTab & vbTab & "Residencial Bosques de Paz. Calle Los Abetos, Calle 15 Ote. " & vbCrLf & vbTab & vbTab & " Y Avenida Los Cipreses; Ilopango Teléfono 2294 3472" & vbCrLf &
            vbTab & vbTab & "email   parroquiabosquesdelapaz@yahoo.com" & vbCrLf &
            vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        cabeceraTextoRange.Font.Name = "Monotype Corsiva"
        cabeceraTextoRange.Font.Size = 14
        cabeceraTextoRange.Font.Bold = 0
        cabeceraTextoRange.Font.Underline = WdUnderline.wdUnderlineNone
        cabeceraTextoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Establecer el interlineado entre párrafos a 1.0 (equivalente a 14 puntos en el espacio de línea)
        cabeceraTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        cabeceraTextoRange.ParagraphFormat.LineSpacing = 14
        cabeceraTextoRange.ParagraphFormat.SpaceAfter = 0
        ' Establecer el formato para "ACTA DE CONFIRMACIÓN"
        Dim tituloRange As Range = doc.Content.Paragraphs.Add().Range
        tituloRange.Text = "ACTA DE MATRIMONIO" & vbCrLf ' Agregar el título
        tituloRange.Font.Name = "Arial"
        tituloRange.Font.Size = 14
        tituloRange.Font.Bold = 1
        tituloRange.Font.Underline = WdUnderline.wdUnderlineSingle
        tituloRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        ' Agregar un salto de sección continuo
        tituloRange.InsertBreak(Type:=WdBreakType.wdSectionBreakContinuous)

        Dim seccionNueva As Section = doc.Sections(2)

        seccionNueva.PageSetup.LeftMargin = cmAPuntos(3) ' Nuevos márgenes izquierdos
        seccionNueva.PageSetup.RightMargin = cmAPuntos(3) ' Nuevos márgenes derechos
        seccionNueva.PageSetup.TopMargin = cmAPuntos(0.63) ' Nuevos márgenes superiores
        seccionNueva.PageSetup.BottomMargin = cmAPuntos(1.17) ' Nuevos márgenes inferiores
        ' Restablecer el formato para el resto del texto
        Dim cuerpoRange As Range = doc.Content.Paragraphs.Add().Range
        cuerpoRange.Font.Name = "Arial"
        cuerpoRange.Font.Size = 14
        cuerpoRange.Font.Bold = 0
        cuerpoRange.Font.Underline = WdUnderline.wdUnderlineNone
        cuerpoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
        'PADRES NOVIO
        If padresNovio = "Ambos padres" Then
            ' Agregar el resto del texto
            cuerpoRange.Text = "El padre Francisco Javier Morán Martínez, párroco de La Parroquia Nuestra Señora de La Paz, en Residencial Bosques de La Paz, en Ilopango hace constar que: en el libro de actas de matrimonio No. " & libro.Trim() & ", acta " & acta.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "En La Parroquia Nuestra Señora de La Paz, en Ilopango, el día " & annioALetra(fechaBendicionMatrimonio.Day).Trim() & " del mes de " & MonthName(fechaBendicionMatrimonio.Month).Trim() & " del año " & annioALetra(fechaBendicionMatrimonio.Year).Trim() & " previos los trámites de derechos civil y canónicos, el " & administradorMatrimonio.Trim() & " bendijo el matrimonio religioso de: " & nombreNovio.Trim() & " de " & annioALetra(edadNovio).Trim() & " años de edad, hijo de " &
                nombrePadreNovio.Trim() & " y de " & nombreMadreNovio.Trim() & ", originario de " & departamentoNovio.Trim()
        End If
        If padresNovio = "Solo madre" Then
            ' Agregar el resto del texto
            cuerpoRange.Text = "El padre Francisco Javier Morán Martínez, párroco de La Parroquia Nuestra Señora de La Paz, en Residencial Bosques de La Paz, en Ilopango hace constar que: en el libro de actas de matrimonio No. " & libro.Trim() & ", acta " & acta.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "En La Parroquia Nuestra Señora de La Paz, en Ilopango, el día " & annioALetra(fechaBendicionMatrimonio.Day).Trim() & " del mes de " & MonthName(fechaBendicionMatrimonio.Month).Trim() & " del año " & annioALetra(fechaBendicionMatrimonio.Year).Trim() & " previos los trámites de derechos civil y canónicos, el " & administradorMatrimonio.Trim() & " bendijo el matrimonio religioso de: " & nombreNovio.Trim() & " de " & annioALetra(edadNovio).Trim() & " años de edad, hijo de " & nombreMadreNovio.Trim() & ", originario de " & departamentoNovio.Trim()
        End If
        If padresNovio = "Solo padre" Then
            ' Agregar el resto del texto
            cuerpoRange.Text = "El padre Francisco Javier Morán Martínez, párroco de La Parroquia Nuestra Señora de La Paz, en Residencial Bosques de La Paz, en Ilopango hace constar que: en el libro de actas de matrimonio No. " & libro.Trim() & ", acta " & acta.Trim() & " se encuentra la que literalmente dice:" & vbCrLf & vbCrLf &
                "En La Parroquia Nuestra Señora de La Paz, en Ilopango, el día " & annioALetra(fechaBendicionMatrimonio.Day).Trim() & " del mes de " & MonthName(fechaBendicionMatrimonio.Month).Trim() & " del año " & annioALetra(fechaBendicionMatrimonio.Year).Trim() & " previos los trámites de derechos civil y canónicos, el " & administradorMatrimonio.Trim() & " bendijo el matrimonio religioso de: " & nombreNovio.Trim() & " de " & annioALetra(edadNovio).Trim() & " años de edad, hijo de " & nombrePadreNovio.Trim() & ", originario de " & departamentoNovio.Trim()
        End If
        'PADRES NOVIA
        If padresNovia = "Ambos padres" Then
            ' Agregar el resto del texto
            cuerpoRange.Text = cuerpoRange.Text & " y " & nombreNovia.Trim() & " de " & annioALetra(edadNovia).Trim() & " años de edad, hija de " & nombrePadreNovia.Trim() & " y de " & nombreMadreNovia.Trim() & " originaria de " & departamentoNovia.Trim() & "." & vbCrLf & vbCrLf
        End If
        If padresNovia = "Solo madre" Then
            ' Agregar el resto del texto
            cuerpoRange.Text = cuerpoRange.Text & " y " & nombreNovia.Trim() & " de " & annioALetra(edadNovia).Trim() & " años de edad, hija de " & nombreMadreNovia.Trim() & " originaria de " & departamentoNovia.Trim() & "." & vbCrLf & vbCrLf
        End If
        If padresNovia = "Solo padre" Then
            ' Agregar el resto del texto
            cuerpoRange.Text = cuerpoRange.Text & " y " & nombreNovia.Trim() & " de " & annioALetra(edadNovia).Trim() & " años de edad, hija de " & nombrePadreNovia.Trim() & " originaria de " & departamentoNovia.Trim() & "." & vbCrLf & vbCrLf
        End If


        ' Restablecer el formato para el resto del texto
        Dim padrinoRange As Range = doc.Content.Paragraphs.Add().Range
        padrinoRange.Font.Name = "Arial"
        padrinoRange.Font.Size = 14
        padrinoRange.Font.Bold = 0
        padrinoRange.Font.Underline = WdUnderline.wdUnderlineNone
        padrinoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify

        ' Agregar el resto del texto
        'PADRINO

        If padrinoMatrimonio = "Padrino" Then
            ' Agregar resto del texto
            padrinoRange.Text = "Fue padrino: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf
        End If
        'MADRINA
        If padrinoMatrimonio = "Madrina" Then
            ' Agregar resto del texto
            padrinoRange.Text = "Fue madrina: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf
        End If
        'MÚLTIPLES PADRINOS
        If padrinoMatrimonio = "Múltiples padrinos" Then
            ' Agregar resto del texto
            padrinoRange.Text = "Fueron padrinos: " & nombrePadrino.Trim() & "." & vbCrLf & vbCrLf
        End If

        'padrinoRange.Text = "Y para efecto que el interesado(a) estime conveniente, se extiende la presente acta de matrimonio en La Parroquia Nuestra Señora de La Paz, en Ilopango a " & annioALetra(fechaExtension.Day).Trim() & " del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaBendicionMatrimonio.Year).Trim()


        ' Restablecer el formato para el resto del texto
        Dim ultimoParrafoRange As Range = doc.Content.Paragraphs.Add().Range
        Dim diaExtension As String = annioALetra(fechaExtension.Day).Trim()
        If diaExtension = "uno" Then
            diaExtension = "un"
        End If
        If diaExtension = "veintiuno" Then
            diaExtension = "veintiún"
        End If
        If diaExtension = "treinta y uno" Then
            diaExtension = "treinta y un"
        End If

        ' Agregar el resto del texto
        If diaExtension = "un" Then
            ultimoParrafoRange.Text = "Y para efecto que el interesado(a) estime conveniente, se extiende la presente acta de matrimonio en La Parroquia Nuestra Señora de La Paz, en Ilopango a " & diaExtension & " día del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaBendicionMatrimonio.Year).Trim() & "." & vbCrLf & vbCrLf
        Else
            ultimoParrafoRange.Text = "Y para efecto que el interesado(a) estime conveniente, se extiende la presente acta de matrimonio en La Parroquia Nuestra Señora de La Paz, en Ilopango a " & diaExtension & " días del mes de " & MonthName(fechaExtension.Month).Trim() & " del año " & annioALetra(fechaBendicionMatrimonio.Year).Trim() & "." & vbCrLf & vbCrLf
        End If

        ultimoParrafoRange.Font.Name = "Arial"
        ultimoParrafoRange.Font.Size = 14
        ultimoParrafoRange.Font.Bold = 0
        ultimoParrafoRange.Font.Underline = WdUnderline.wdUnderlineNone
        ultimoParrafoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify


        ' Restablecer el formato para el resto del texto
        Dim finalRange As Range = doc.Content.Paragraphs.Add().Range
        finalRange.Font.Name = "Arial"
        finalRange.Font.Size = 14
        finalRange.Font.Bold = 0
        finalRange.Font.Underline = WdUnderline.wdUnderlineNone
        finalRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter

        ' Agregar el resto del texto
        finalRange.Text = vbTab & vbTab & vbTab & vbTab & vbTab & "Pbro. Francisco Javier Morán Martínez" & vbCrLf
        finalRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        finalRange.ParagraphFormat.SpaceAfter = 0
        Dim finalTextoRange As Range = doc.Content.Paragraphs.Add().Range
        finalTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly
        finalTextoRange.Text = vbTab & vbTab & vbTab & vbTab & vbTab & "Párroco"
        finalTextoRange.Font.Name = "Arial"
        finalTextoRange.Font.Size = 14
        finalTextoRange.Font.Bold = 0
        finalTextoRange.Font.Underline = WdUnderline.wdUnderlineNone
        finalTextoRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        'finalTextoRange.ParagraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceExactly

        finalTextoRange.ParagraphFormat.LineSpacing = 12
        finalTextoRange.ParagraphFormat.SpaceAfter = 0
        finalTextoRange.ParagraphFormat.SpaceBefore = 0
        ' Dejar la aplicación Word abierta sin guardar el archivo
        ' Puedes cerrar manualmente la aplicación Word cuando hayas terminado.

        ' Liberar recursos
        System.Runtime.InteropServices.Marshal.ReleaseComObject(doc)
    End Sub

    'Función para convertir centímetros a puntos (1 cm = 28.35 puntos)
    Private Function cmAPuntos(ByVal cm As Single) As Single
        Return cm * 28.35F
    End Function
End Module
