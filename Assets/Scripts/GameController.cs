using System.Collections;
using System.Collections.Generic;
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

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        Score = (int)player.transform.position.z;
    }

    public void Death()
    {
        //Player belirli y değerlerini geçtiği zaman bu fonksiyon çağıralacak
    }

    public void Restart()
    {
        //UI tasarlandıktan sonra scene manager ile bu çağıralacak
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
        //Player Coin Collisonu olduğu zaman bu fonksiyon çağıralacak
    }

}
