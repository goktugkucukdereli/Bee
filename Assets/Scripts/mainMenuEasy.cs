using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuEasy : MonoBehaviour
{
    public GameObject btnplay;
    public GameObject btnexit;
    public GameObject btneasy;
    public GameObject btnhard;
    public GameObject btnveryhard;
    public Slider btnSlider;

    public void play()
    {
        btnplay.SetActive(false);
        btneasy.SetActive(true);
        btnhard.SetActive(true);
        btnveryhard.SetActive(true);
    }

    public void selectButton()
    {
        if(btnSlider.value <= 1)
        {
            SceneManager.LoadScene(1);
        }
        else if(btnSlider.value > 1 && btnSlider.value <= 2)
        {
            SceneManager.LoadScene(2);
        }
        else if(btnSlider.value > 2)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void exit()
    {
        Application.Quit();
    }
}
