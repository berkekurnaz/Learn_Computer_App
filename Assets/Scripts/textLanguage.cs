using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textLanguage : MonoBehaviour
{

    [Header("Panel Main Menu")]
    [SerializeField] private Text txtLearningComputer;
    [SerializeField] private Text btnStart;
    [SerializeField] private Text btnLearn;
    [SerializeField] private Text btnHowToUse;
    [SerializeField] private Text btnAbout;

    [Header("Panel Learn")]
    [SerializeField] private Text txtComputerHardware;
    [SerializeField] private Text btnCpu;
    [SerializeField] private Text btnMotherboard;
    [SerializeField] private Text btnRam;
    [SerializeField] private Text btnVideoCard;
    [SerializeField] private Text btnHdd;
    [SerializeField] private Text btnSsd;
    [SerializeField] private Text txtComputerEnvironment;
    [SerializeField] private Text btnScreen;
    [SerializeField] private Text btnKeyboard;
    [SerializeField] private Text btnMouse;
    [SerializeField] private Text btnHeadset;
    [SerializeField] private Text btnPrinter;
    [SerializeField] private Text btnSoundSystem;

    [Header("Panel How To Use")]
    [SerializeField] private Text txtHowToUse;
    [SerializeField] private Text txtRow1_use;
    [SerializeField] private Text txtRow2_use;
    [SerializeField] private Text txtRow3_use;
    [SerializeField] private Text btnBack_use;

    [Header("Panel About")]
    [SerializeField] private Text txtAbout_about;
    [SerializeField] private Text txtAboutDetail_about;
    [SerializeField] private Text btnBack_about;

    void Start()
    {
        LoadMainMenuText();
        LoadLearnText();
        LoadHowToUseText();
        LoadAboutText();
    }

    void LoadMainMenuText()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            txtLearningComputer.text = "Learning Computer\n----------------";
            btnStart.text = "Start Game";
            btnLearn.text = "Learn Parts";
            btnHowToUse.text = "How To Use ?";
            btnAbout.text = "About";
        }
        else
        {
            txtLearningComputer.text = "Bilgisayarı Öğreniyorum\n----------------";
            btnStart.text = "Nesneleri Tanıtmaya Başla";
            btnLearn.text = "Parçaları Öğren";
            btnHowToUse.text = "Nasıl Kullanılır ?";
            btnAbout.text = "Nedir ?";
        }
    }

    void LoadLearnText()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            txtComputerHardware.text = "Computer Hardware\n****************";
            txtComputerEnvironment.text = "Computer Environment\n****************";
            btnCpu.text = "Cpu";
            btnMotherboard.text = "Motherboard";
            btnRam.text = "Ram";
            btnVideoCard.text = "Video Card";
            btnHdd.text = "Hdd";
            btnSsd.text = "Ssd";
            btnScreen.text = "Screen";
            btnKeyboard.text = "Keyboard";
            btnMouse.text = "Mouse";
            btnHeadset.text = "Headset";
            btnPrinter.text = "Printer";
            btnSoundSystem.text = "Sound System";
        }
        else
        {
            txtComputerHardware.text = "Bilgisayar Donanımı\n****************";
            txtComputerEnvironment.text = "Çevre Bileşenleri\n****************";
            btnCpu.text = "İşlemci";
            btnMotherboard.text = "Anakart";
            btnRam.text = "Ram";
            btnVideoCard.text = "Ekran Kartı";
            btnHdd.text = "Hdd";
            btnSsd.text = "Ssd";
            btnScreen.text = "Monitör";
            btnKeyboard.text = "Klavye";
            btnMouse.text = "Fare";
            btnHeadset.text = "Kulaklık";
            btnPrinter.text = "Yazıcı";
            btnSoundSystem.text = "Ses Sistemi";
        }
    }

    void LoadHowToUseText()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            txtHowToUse.text = "How To Use ?\n*********************";
            txtRow1_use.text = "1-) Nesneleri Tanıtmaya Başla Butonuna Tıkla"; // Ingilizcesi Eklenecek.
            txtRow2_use.text = "2-) Kamerayı Kitabın İçerisindeki Resimlere Göster"; // Ingilizcesi Eklenecek.
            txtRow3_use.text = "3-) Ekranda Açılan Parçayı İncele"; // Ingilizcesi Eklenecek.
            btnBack_use.text = "Back";
        }
        else
        {
            txtHowToUse.text = "Nasıl Kullanılır ?\n*********************";
            txtRow1_use.text = "1-) Nesneleri Tanıtmaya Başla Butonuna Tıkla";
            txtRow2_use.text = "2-) Kamerayı Kitabın İçerisindeki Resimlere Göster";
            txtRow3_use.text = "3-) Ekranda Açılan Parçayı İncele";
            btnBack_use.text = "Geri Dön";
        }
    }

    void LoadAboutText()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            txtAbout_about.text = "About\n*********************";
            txtAboutDetail_about.text = "About Detail Text"; // Buraya Ingilizce Nedir Bolumu Eklenecek.
            btnBack_about.text = "Back";
        }
        else
        {
            txtAbout_about.text = "Nedir ?\n*********************";
            txtAboutDetail_about.text = "İlköğretim Düzeyindeki Öğrencilere Bilgisayar Parçalarını Daha İyi Tanıtmak Ve Öğretmek Amacıyla Hazırlanmış Mobil Uygulamadır.";
            btnBack_about.text = "Geri Dön";
        }
    }

}
