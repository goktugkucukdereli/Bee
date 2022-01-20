using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeSpeed : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.velocity = transform.right * speed;
    }
}
