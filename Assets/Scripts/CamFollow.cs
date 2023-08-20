using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform cameraTarget; //Kameran�n takip edece�i hedef nesneyi referans al�r.
    public float speed=10f; // Kameran�n hedefi takip etme h�z�n� belirler. 
    public Vector3 dist; //Kamera ve hedef aras�ndaki ba�lang�� mesafesini belirler. 
    public Transform lookTarget; //Kameran�n bakaca�� noktay� belirler. 
    private void LateUpdate()
    {
        Vector3 dPos = cameraTarget.position+dist; // Kameran�n hedefi takip edece�i hedef noktan�n hesaplanmas�.
        Vector3 sPos = Vector3.Lerp(transform.position,dPos,speed*Time.deltaTime); // Kamera pozisyonunu, mevcut pozisyonundan hedef pozisyonuna do�ru yava��a hareket ettirir. 
        transform.position = sPos; //Kameran�n yeni pozisyonunu ayarlar, yani hedefi takip eden pozisyon.
        transform.LookAt(lookTarget.position); //Kamera, belirtilen bak�� noktas�na do�ru y�nlendirilir. Bu, kameran�n hedefe her zaman do�ru bakmas�n� sa�lar.
    }
}
