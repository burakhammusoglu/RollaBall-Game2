using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanacakObje : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); // objeyi döndürüyoruz. // Time.deltatime ile hızını azaltıyoruz.
        
    }
}
