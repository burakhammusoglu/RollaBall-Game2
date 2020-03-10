using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakiMesafe;
    void Start()
    {
        aradakiMesafe = transform.position - top.transform.position; //kamerayı topu takip etmesini ayarladık.
        
    }

    
    void LateUpdate() // Late update kamera olaylarında kullanılır ve tüm updateler bittikten sonra çalışır.
        //Bu şekilde kamera görüntüsü daha güzel olur
    {
        transform.position = top.transform.position + aradakiMesafe; //kameranın rotasyonları.
        
    }
}
