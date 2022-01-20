using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public Vector3 rotateVector = new Vector3(0, 0, 0);
    public float speed;

    void Update()
    {
        transform.Rotate(rotateVector * speed * Time.fixedDeltaTime);
    }
}
