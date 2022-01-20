using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bee : MonoBehaviour
{
    void Update()
    {
        if(transform.parent != null && Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            GetComponent<beeSpeed>().speed = 60;
            transform.parent.GetChild(0).gameObject.SetActive(false);
            transform.SetParent(null);
            //Touch finger = Input.GetTouch(0);
        }
    }
}
