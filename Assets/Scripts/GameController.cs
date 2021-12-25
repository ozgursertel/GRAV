using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public GameObject endGamePanel;
    public GameObject creditsPanel;
    public TextMeshProUGUI scoreText;
    
    //public GameObject endPanel;
    private void Start()
    {
        Score = 0;
        isGameStarted = false;
        startPanel.SetActive(true);
        inGamePanel.SetActive(false);
        adsScript = googleAds.GetComponent<GoogleAds>();
    }

    private void Update()
    {
        Score = (int)player.transform.position.z;
    }

    public void Death()
    {
        isGameStarted = false;
        isGameEnded = true;
        endGamePanel.SetActive(true);
        inGamePanel.SetActive(false);
        adsScript.GameOver();
    }

    public void Restart()
    {
        //UI tasarland�ktan sonra scene manager ile bu �a��ralacak
    }

    public void GameStarted()
    {
        Debug.Log("S");
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
        //Player Coin Collisonu oldu�u zaman bu fonksiyon �a��ralacak
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void credits()
    {
        startPanel.SetActive(false);
        endGamePanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }

}
