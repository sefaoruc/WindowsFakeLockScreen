Imports System.Net.Mail
Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Dim MyMailMessage As New MailMessage()

            Try
            MyMailMessage.From = New MailAddress("mailadress@gmail.com")
            MyMailMessage.To.Add("mailadress@gmail.com")
                MyMailMessage.Subject = TextBox1.Text
                MyMailMessage.Body = TextBox2.Text
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("mailadress@gmail.com", "PAROLA")
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
            MyMailMessage.From = New MailAddress("mailadress@gmail.com")
            MyMailMessage.To.Add("mailadress@gmail.com")
            MyMailMessage.Subject = TextBox1.Text
            MyMailMessage.Body = TextBox2.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("mailadress@gmail.com", "PAROLA")
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
