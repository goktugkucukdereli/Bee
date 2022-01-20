using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuPanelEasy : MonoBehaviour
{
    public GameObject panelAgain;

    public void restartButton()
    {
        SceneManager.LoadScene("Easy");
    }

    public void mainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
