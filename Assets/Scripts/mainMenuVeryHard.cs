using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuVeryHard : MonoBehaviour
{
    public GameObject bee;
    public Text timeText;
    public GameObject panelAgain;
    private float time = 60f;

    public void restartButton()
    {
        SceneManager.LoadScene("VeryHard");
    }

    public void timer()
    {
        timeText.text = time.ToString("F0");
    }
    

    private void Update()
    {
        Invoke("timer", 0f);

        time = time - Time.deltaTime;

        if (time <= 0 || bee.transform.position.x < -210f || bee.transform.position.y < -105f || bee.transform.position.y > 105f)
        {
            panelAgain.SetActive(true);
            
            Destroy(timeText);
            Debug.Log(this.gameObject);
            Destroy(bee);
        }
    }
    public void mainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
