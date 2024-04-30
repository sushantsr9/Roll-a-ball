using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Include TextMeshPro namespace

public class hii : MonoBehaviour
{
    int enemy = 0;
    [SerializeField] TMP_Text coinsText; // Use TMP_Text for TextMeshPro

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            enemy= enemy+5;

            // Update TextMeshPro text using its specific method
            coinsText.text = "Coins: " + enemy; 
        }
    }
}