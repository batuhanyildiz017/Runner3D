using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Coin : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endText;
    public PlayerController controller;
    public Animator playerAnim;
    public GameObject Player;
    public GameObject EndPanel;
    private void Start()
    {
        score = 0;
        //score = PlayerPrefs.GetInt("coin");
        scoreText.text = "Coin: "+score.ToString();
        playerAnim= Player.GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("End"))
        {
            EndPanel.SetActive(true);
            Debug.Log("Sona geldik.");
            controller.runningSpeed = 0;
            transform.Rotate(transform.rotation.x,180,transform.rotation.z,Space.Self);
            if (score >= 35)
            {
                endText.text = "You Win!!!";
                Debug.Log("you win !!!!");
                playerAnim.SetBool("win",true);
            }
            else
            {
                endText.text = "You Lose :(";
                Debug.Log("You Lose!!!");
                playerAnim.SetBool("lose", true);
            }
        }
    }

    void AddCoin()
    {
        score++;
        scoreText.text = "Coin: "+score.ToString();
        //PlayerPrefs.SetInt("coin",score);
    }
    
}
