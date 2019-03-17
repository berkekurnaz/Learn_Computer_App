using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class informationControl : MonoBehaviour
{

    [Header("Computer Hardware")]
    [SerializeField] private Text txtName;
    [SerializeField] private Text txtNameDetail;

    [Header("Turkish Computer Hardware")]
    [SerializeField] private string strCpu_tr;
    [SerializeField] private string strMotherboard_tr;
    [SerializeField] private string strRam_tr;
    [SerializeField] private string strVideocard_tr;
    [SerializeField] private string strHdd_tr;
    [SerializeField] private string strSdd_tr;

    [Header("Turkish Computer Environment")]
    [SerializeField] private string strScreen_tr;
    [SerializeField] private string strKeyboard_tr;
    [SerializeField] private string strMouse_tr;
    [SerializeField] private string strHeadset_tr;
    [SerializeField] private string strPrinter_tr;
    [SerializeField] private string strSoundSystem_tr;

    [Header("English Computer Hardware")]
    [SerializeField] private string strCpu_eg;
    [SerializeField] private string strMotherboard_eg;
    [SerializeField] private string strRam_eg;
    [SerializeField] private string strVideocard_eg;
    [SerializeField] private string strHdd_eg;
    [SerializeField] private string strSdd_eg;

    [Header("English Computer Environment")]
    [SerializeField] private string strScreen_eg;
    [SerializeField] private string strKeyboard_eg;
    [SerializeField] private string strMouse_eg;
    [SerializeField] private string strHeadset_eg;
    [SerializeField] private string strPrinter_eg;
    [SerializeField] private string strSoundSystem_eg;

    [Header("Panels")]
    [SerializeField] private GameObject pnlMainMenu;
    [SerializeField] private GameObject pnlLearn;
    [SerializeField] private GameObject pnlHowToUse;
    [SerializeField] private GameObject pnlAbout;
    [SerializeField] private GameObject pnlInformation;

    void CloseAllPanels()
    {
        pnlMainMenu.SetActive(false);
        pnlLearn.SetActive(false);
        pnlHowToUse.SetActive(false);
        pnlAbout.SetActive(false);
        pnlInformation.SetActive(false);
    }

    public void backClick()
    {
        CloseAllPanels();
        pnlLearn.SetActive(true);
    }

    public void btnClick(int id)
    {
        CloseAllPanels();
        pnlInformation.SetActive(true);
        if (Application.systemLanguage == SystemLanguage.English)
        {
            LoadEnglishText(id);
        }
        else
        {
            LoadTurkishText(id);
        }
    }

    void LoadEnglishText(int id)
    {
        if (id == 0)
        {
            txtName.text = "Cpu";
            txtNameDetail.text = strCpu_eg;
        }
        else if (id == 1)
        {
            txtName.text = "Motherboard";
            txtNameDetail.text = strMotherboard_eg;
        }
        else if (id == 2)
        {
            txtName.text = "Ram";
            txtNameDetail.text = strRam_eg;
        }
        else if (id == 3)
        {
            txtName.text = "Video Card";
            txtNameDetail.text = strVideocard_eg;
        }
        else if (id == 4)
        {
            txtName.text = "Hdd";
            txtNameDetail.text = strHdd_eg;
        }
        else if (id == 5)
        {
            txtName.text = "Ssd";
            txtNameDetail.text = strSdd_eg;
        }
        else if (id == 6)
        {
            txtName.text = "Screen";
            txtNameDetail.text = strScreen_eg;
        }
        else if (id == 7)
        {
            txtName.text = "Keyboard";
            txtNameDetail.text = strKeyboard_eg;
        }
        else if (id == 8)
        {
            txtName.text = "Mouse";
            txtNameDetail.text = strMouse_eg;
        }
        else if (id == 9)
        {
            txtName.text = "Headset";
            txtNameDetail.text = strHeadset_eg;
        }
        else if (id == 10)
        {
            txtName.text = "Printer";
            txtNameDetail.text = strPrinter_eg;
        }
        else if (id == 11)
        {
            txtName.text = "Sound System";
            txtNameDetail.text = strSoundSystem_eg;
        }
    }

    void LoadTurkishText(int id)
    {
        if (id == 0)
        {
            txtName.text = "İşlemci";
            txtNameDetail.text = strCpu_tr;
        }
        else if (id == 1)
        {
            txtName.text = "Anakart";
            txtNameDetail.text = strMotherboard_tr;
        }
        else if (id == 2)
        {
            txtName.text = "Ram";
            txtNameDetail.text = strRam_tr;
        }
        else if (id == 3)
        {
            txtName.text = "Ekran Kartı";
            txtNameDetail.text = strVideocard_tr;
        }
        else if (id == 4)
        {
            txtName.text = "Hdd";
            txtNameDetail.text = strHdd_tr;
        }
        else if (id == 5)
        {
            txtName.text = "Ssd";
            txtNameDetail.text = strSdd_tr;
        }
        else if (id == 6)
        {
            txtName.text = "Monitör";
            txtNameDetail.text = strScreen_tr;
        }
        else if (id == 7)
        {
            txtName.text = "Klavye";
            txtNameDetail.text = strKeyboard_tr;
        }
        else if (id == 8)
        {
            txtName.text = "Fare";
            txtNameDetail.text = strMouse_tr;
        }
        else if (id == 9)
        {
            txtName.text = "Kulaklık";
            txtNameDetail.text = strHeadset_tr;
        }
        else if (id == 10)
        {
            txtName.text = "Yazıcı";
            txtNameDetail.text = strPrinter_tr;
        }
        else if (id == 11)
        {
            txtName.text = "Ses Sistemi";
            txtNameDetail.text = strSoundSystem_tr;
        }
    }

}
