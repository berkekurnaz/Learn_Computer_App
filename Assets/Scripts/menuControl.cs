using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{

    [Header("Panels")]
    [SerializeField] private GameObject pnlMainMenu;
    [SerializeField] private GameObject pnlLearn;
    [SerializeField] private GameObject pnlHowToUse;
    [SerializeField] private GameObject pnlAbout;
    [SerializeField] private GameObject pnlInformation;

    void Start()
    {
        CloseAllPanels();
        pnlMainMenu.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            CloseAllPanels();
            pnlMainMenu.SetActive(true);
        }
    }

    void CloseAllPanels()
    {
        pnlMainMenu.SetActive(false);
        pnlLearn.SetActive(false);
        pnlHowToUse.SetActive(false);
        pnlAbout.SetActive(false);
        pnlInformation.SetActive(false);
    }

    /* Main Menu Screen Button Events */
    /* ------------------------------ */
    public void btnStart_Click()
    {
        SceneManager.LoadScene("ArScene");
    }
    public void btnLearn_Click()
    {
        CloseAllPanels();
        pnlLearn.SetActive(true);
    }
    public void btnHowToUse_Click()
    {
        CloseAllPanels();
        pnlHowToUse.SetActive(true);
    }
    public void btnAbout_Click()
    {
        CloseAllPanels();
        pnlAbout.SetActive(true);
    }

    /* About Screen And How To Use Screen Button Events */
    /* ------------------------------ */
    public void btnBack_Click()
    {
        CloseAllPanels();
        pnlMainMenu.SetActive(true);
    }

    /* Learn Screen Button Events */
    /* ------------------------------ */


}
