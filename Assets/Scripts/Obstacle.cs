using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerController controller;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Engele temas etti.");
            gameManager.LoadScene();
        } else if (other.CompareTag("End"))
        {
            Debug.Log("Sona geldik.");
            controller.runningSpeed = 0;
            
        }
    }
}
