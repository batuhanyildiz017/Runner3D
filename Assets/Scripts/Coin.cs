using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Coin : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreText;
    private void Start()
    {
        score = PlayerPrefs.GetInt("coin");
        scoreText.text = "Coin: "+score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
    }

    void AddCoin()
    {
        score++;
        scoreText.text = "Coin: "+score.ToString();
        PlayerPrefs.SetInt("coin",score);
    }
    
}
