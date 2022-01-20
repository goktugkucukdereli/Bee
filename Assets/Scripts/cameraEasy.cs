using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraEasy : MonoBehaviour
{
    public Transform player;

    public float smoothX;
    public float smoothY;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    void Start()
    {
        player = GameObject.Find("bee-01").transform; // oyun içindeki objenin bulunduğu noktayı alıyor
    }

    private void LateUpdate()
    {
        //transform.position = player.position; // takip edilecek pozisyon playerin pozisyonu

        float posX = Mathf.MoveTowards(transform.position.x, player.position.x, smoothX);
        // x ekseninde takip, burada oyun ekranı sabit ise maxX değeri 99999 gibi çok yüksek verilmeli

        float posY = Mathf.MoveTowards(transform.position.y, player.position.y, smoothY); // y ekseninde takip

        transform.position = new Vector3(Mathf.Clamp(posX, minX, maxX), Mathf.Clamp(posY, minY, maxY), transform.position.z);
        // sınırlama denilince akla ilk gelen Mathf.Clamp olmalı
    }
}
