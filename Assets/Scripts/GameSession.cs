﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour {

    // Configuration parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlock = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI livesText;

    // State variables
    [SerializeField] int playerScore = 0;
    [SerializeField] int playerLives = 3;

    private void Awake ()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1) 
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else 
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start () 
    {
        scoreText.text = playerScore.ToString();
        livesText.text = playerLives.ToString(playerLives + " Lives");
    }

    void Update () 
    {
        Time.timeScale = gameSpeed;
	}

    public void AddPoints ()
    {
        playerScore += pointsPerBlock;
        scoreText.text = playerScore.ToString();
    }

    // NEW (Jan 29, 2019)
    public void RemoveLife ()
    {
        playerLives -= 1;
        livesText.text = playerLives.ToString(playerLives + " Lives");
    }

    public void ResetScore ()
    {
        Destroy(gameObject);
    }
}