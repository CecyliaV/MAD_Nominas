'Imports System.Runtime.InteropServices

Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Imports FontAwesome.Sharp
Public Class Form1

    Private currentbtn As IconButton
    Private leftborderbtn As Panel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 60)
        Panelmenu.Controls.Add(leftborderbtn)

    End Sub

    Private Sub activatebutton(senderbtn As Object, customcolor As Color)

        If senderbtn IsNot Nothing Then

            disablebutton()

            currentbtn = CType(senderbtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(72, 27, 102)
            currentbtn.ForeColor = Color.FromArgb(200, 200, 200)
            currentbtn.IconColor = Color.FromArgb(200, 200, 200)
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftborderbtn.BackColor = Color.FromArgb(97, 180, 166)
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()

            IconFormAct.IconChar = currentbtn.IconChar
            IconFormAct.IconColor = Color.FromArgb(200, 200, 200)

        End If

    End Sub

    Private Sub disablebutton()

        If currentbtn IsNot Nothing Then

            currentbtn.BackColor = Color.FromArgb(200, 200, 200)
            currentbtn.ForeColor = Color.FromArgb(72, 27, 102)
            currentbtn.IconColor = Color.FromArgb(72, 27, 102)
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click   'mis datos
        activatebutton(sender, Color.FromArgb(97, 180, 166))

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click   'generar recibos
        activatebutton(sender, Color.FromArgb(97, 180, 166))

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click   'solicitar vacaciones
        activatebutton(sender, Color.FromArgb(97, 180, 166))

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click   'resumen de pagos
        activatebutton(sender, Color.FromArgb(97, 180, 166))

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click   'agregar
        activatebutton(sender, Color.FromArgb(97, 180, 166))

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click   'reportes
        activatebutton(sender, Color.FromArgb(97, 180, 166))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim recover As Boolean
        Dim pdfdoc As New Document()
        Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(pdfdoc, New FileStream("C:\Users\Usuario\Downloads\Prueba imagen.pdf", FileMode.Create))
        Dim imagen As iTextSharp.text.Image
        imagen = iTextSharp.text.Image.GetInstance("D:\Documentos\FCFM\Materias\MAD\nominalogo .jpg", recover)
        imagen.ScalePercent(30)

        pdfdoc.Open()
        pdfdoc.Add(imagen)
        pdfdoc.Add(New Paragraph("Empresa"))
        pdfdoc.NewPage()
        pdfdoc.Add(New Paragraph("Hello world again"))
        pdfdoc.Close()

        MsgBox("EL archivo se descargo en la siguiente ruta: C:\Users\Usuario\Downloads\Prueba imagen.pdf", vbOK, "Descarga")

    End Sub
End Class
