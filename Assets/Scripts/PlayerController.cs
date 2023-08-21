using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;
    float touchX = 0;
    float newX = 0;
    public float xSpeed;
    public float limitX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SwipeController();
    }
    private void SwipeController()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //Debug.Log("Finger moved");
            touchX = Input.GetTouch(0).deltaPosition.x / Screen.width;  //ekraný kaydýrdýðýmýzda gelen x deðeri
        }
        else
        {
            touchX = 0;
        }
        newX = transform.position.x + xSpeed * touchX * Time.deltaTime; //yeni x: karakter pozisyonu kaydýrdýðýmýzda gelen x deðeri * speed
        newX = Mathf.Clamp(newX, -limitX, limitX); //karakterin platformun dýþýna çýkmamasý için x deðerini limitleme
        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + runningSpeed * Time.deltaTime); //z ekseninde running speed hýzýyla koþmasý
        transform.position = newPosition; //new pozisyonun karakter pozisyonuna eþitlenmesi
    }
}
