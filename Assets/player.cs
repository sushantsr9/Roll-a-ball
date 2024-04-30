using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    
    Rigidbody r1;

    float moveh;
    float movev;
    float j;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        r1 = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        moveh = Input.GetAxis("Horizontal");
        movev = Input.GetAxis("Vertical");
        j = Input.GetAxis("Jump");
        Vector3 m = new Vector3(moveh, j, movev);
        r1.AddForce(m * speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            //p1.Play();
        }
    }

}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI; // Import Unity UI library

// using TMPro;

// public class player : MonoBehaviour
// {
    
    
//     Rigidbody r1;
//     float moveh;
//     float movev;
//     float j;
//     public int speed = 5;
//     private int score = 0; // Variable to store player's score
//     public Text scoreText; // Reference to UI Text element to display score

//     void Start()
//     {
//         r1 = GetComponent<Rigidbody>();
//         UpdateScoreText(); // Initialize score text
//     }

//     void Update()
//     {
//         moveh = Input.GetAxis("Horizontal");
//         movev = Input.GetAxis("Vertical");
//         j = Input.GetAxis("Jump");
//         Vector3 m = new Vector3(moveh, j, movev);
//         r1.AddForce(m * speed);
//     }

//     void OnCollisionEnter(Collision collision)
//     {
//         if (collision.transform.gameObject.CompareTag("enemy"))
//         {
//             Destroy(collision.gameObject);
//             score += 10; // Increment score by 10 for each enemy destroyed
//             UpdateScoreText(); // Update score text
//         }
//     }

//     void UpdateScoreText()
//     {
//         if (scoreText != null)
//         {
//             scoreText.text = "Score: " + score.ToString(); // Update score text
//         }
//     }
// }





