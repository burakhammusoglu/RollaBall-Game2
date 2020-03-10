using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topKontrol : MonoBehaviour
{
    Rigidbody fizik; // rigidbody sınıfından metotları kullanabilmemiz için
    public int hiz;
    int sayac = 0;
    public int nesneSayisi;
    public Text sayacText;
    public Text oyunBittimiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>(); // componentlere ulaştık

        
    }

    
    void FixedUpdate() // fixedupdate metodu düzenli çalışır ve fizik işlemlerini bu metod içinde yaparız.
    {
        // hareket ettiriyoruz
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec*hiz);
        
    }
    void OnTriggerEnter(Collider other) 
    // OnTriggerStay  Objeyle temas halinde sürekli mesaj verir.
    // OnTriggerExit  Objeyle temas etmeyi bıraktığında mesaj verir.
    // OnTriggerEnter Objeyler temas halinde bir defa mesaj verir.
    {
        if (other.gameObject.tag == "engel") // temas ettiğimiz objenin etiketi engelse yok et.
        {
            other.gameObject.SetActive(false); // objeyi yok etmiyoruz kapatıyoruz.Aslında hala orada ama gözükmüyor.
                                               //Destroy(other.gameObject); // Destroy yok etme komutu. Temas edilen gameObjecti yok et.
            sayac++; // temas oldugunda sayac artsın.
            sayacText.text = "Sayac =" + sayac;

            if (sayac == nesneSayisi)
            {
                oyunBittimiText.text = "Oyun Bitti";
            }
        }

        //Destroy(other.gameObject); // Destroy yok etme komutu. Temas edilen gameObjecti yok et.

    }
    
}
