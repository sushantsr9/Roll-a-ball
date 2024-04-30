using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import Unity UI library

public class scoringg : MonoBehaviour
{
    private int score = 0; // Variable to store player's score
    public Text scoreText; // Reference to UI Text element to display score

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            score += 10; // Increment score by 10 for each enemy destroyed
            UpdateScoreText(); // Update score text
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); // Update score text
        }
    }
}

