using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int Score;
    GameObject player;
    #region Singleton
    public static GameController Instance;
    private void Awake()
    {
        Instance = this;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    #endregion
    public bool isGameStarted = false;
    public bool isGameEnded;
    public GameObject googleAds;
    private GoogleAds adsScript;
    public GameObject startPanel;
    public GameObject inGamePanel;

    public GameObject ScoreObject;
    TextMeshPro scoreText;
    
    //public GameObject endPanel;
    private void Start()
    {
        Score = 0;
        isGameStarted = false;
        startPanel.SetActive(true);
        inGamePanel.SetActive(false);
        adsScript=googleAds.GetComponent<GoogleAds>();
        scoreText = ScoreObject.GetComponent<TextMeshPro>();

    }

    private void Update()
    {
        Score = (int)player.transform.position.z;
        scoreText.SetText("Score : " + Score);
    }

    public void Death()
    {
        isGameStarted = false;
        isGameEnded = true;
        adsScript.GameOver();
    }

    public void Restart()
    {
        //UI tasarlandýktan sonra scene manager ile bu çaðýralacak
    }

    public void GameStarted()
    {
        startPanel.SetActive(false);
        inGamePanel.SetActive(true);
        isGameStarted = true;
    }

    public void SetHighScore()
    {
        if(Score > PlayerPrefs.GetInt("HighScore",0))
        {
            Debug.Log("High Score Setted");
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }


    public void addCoin()
    {
        //Player Coin Collisonu olduðu zaman bu fonksiyon çaðýralacak
    }

}
