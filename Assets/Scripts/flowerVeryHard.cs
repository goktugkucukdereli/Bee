using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerVeryHard : MonoBehaviour
{
    public GameObject[] flower1;
    public Vector3 flowerRandomPos;
    int count = 1;
    void Start()
    {
        InvokeRepeating("flowerCreate", 0f, 0.1f);
    }

    public void flowerCreate()
    {
        if (count < 20)
        {
        Vector3 vec = new Vector3(flowerRandomPos.x + (count * 100f), Random.Range(flowerRandomPos.y, -flowerRandomPos.y), 0f);
        Debug.Log(vec.ToString());
        Instantiate(flower1[Random.Range(0, flower1.Length)], vec, Quaternion.identity);
        count++;
    }
        else
        {
            CancelInvoke();
        }
    }
}
