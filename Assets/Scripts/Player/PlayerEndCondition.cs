using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerEndCondition : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject gameOverPanel;

    public TMP_Text scoreText;

    public ScrapTrigger scrapTrigger;

    public void Win()
    {
        Time.timeScale = 0;
        winPanel.SetActive(true);
        scoreText.gameObject.SetActive(true);
        scoreText.text = scrapTrigger.scrapCollected.ToString();
    }
    
    public void Die()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        scoreText.gameObject.SetActive(true);
        scoreText.text = scrapTrigger.scrapCollected.ToString();
    }
}
