using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Include TextMeshPro namespace

public class coin : MonoBehaviour
{
    int coins = 0;
    [SerializeField] TMP_Text coinsText; // Use TMP_Text for TextMeshPro

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coins= coins+10;

            // Update TextMeshPro text using its specific method
            coinsText.text = "Coins: " + coins; 
        }
    }
}