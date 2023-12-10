using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class ScoreDisplay : MonoBehaviour
{
    TextMeshProUGUI scoreText; // Change the type to TextMeshProUGUI
    GameSession gameSession;

    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); // Change GetComponent<TextMeshProUGUI>()
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameSession.GetScore().ToString();
    }
}
