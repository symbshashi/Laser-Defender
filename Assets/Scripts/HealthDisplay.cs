using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class HealthDisplay : MonoBehaviour
{
    TextMeshProUGUI healthText; // Change the type to TextMeshProUGUI
    Player player;

    // Use this for initialization
    void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>(); // Change GetComponent<TextMeshProUGUI>()
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = player.GetHealth().ToString();
    }
}
