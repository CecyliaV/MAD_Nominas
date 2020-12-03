Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Form1
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

        MsgBox("EL archivo se descargo en la siguiente ruta: D:\Documentos\FCFM\Materias\MAD\nominalogo .jpg", vbOK, "Descarga")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
