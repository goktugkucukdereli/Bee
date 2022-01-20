using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactEasy : MonoBehaviour
{
    public GameObject again;
    public GameObject bee;
    public GameObject[] Bars;
    int i = 0;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "flower1")
        {
            col.transform.GetChild(0).gameObject.SetActive(false);
            this.GetComponent<beeSpeed>().speed = 0;
            transform.SetParent(col.transform);
            fullTheBar();
        }
        i++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

    public void fullTheBar()
    {
        Bars[i].SetActive(false);
    }

    private void Update()
    {
        if (transform.position.x < -210f || transform.position.y < -105f || transform.position.y > 105f)
        {
            bee.SetActive(false);
            again.SetActive(true);
        }
    }
}
