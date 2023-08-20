using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform cameraTarget; //Kameranýn takip edeceði hedef nesneyi referans alýr.
    public float speed=10f; // Kameranýn hedefi takip etme hýzýný belirler. 
    public Vector3 dist; //Kamera ve hedef arasýndaki baþlangýç mesafesini belirler. 
    public Transform lookTarget; //Kameranýn bakacaðý noktayý belirler. 
    private void LateUpdate()
    {
        Vector3 dPos = cameraTarget.position+dist; // Kameranýn hedefi takip edeceði hedef noktanýn hesaplanmasý.
        Vector3 sPos = Vector3.Lerp(transform.position,dPos,speed*Time.deltaTime); // Kamera pozisyonunu, mevcut pozisyonundan hedef pozisyonuna doðru yavaþça hareket ettirir. 
        transform.position = sPos; //Kameranýn yeni pozisyonunu ayarlar, yani hedefi takip eden pozisyon.
        transform.LookAt(lookTarget.position); //Kamera, belirtilen bakýþ noktasýna doðru yönlendirilir. Bu, kameranýn hedefe her zaman doðru bakmasýný saðlar.
    }
}
