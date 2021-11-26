using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //�u an sadece karakter hareketine odaklanal�m ben �l�m durumlar�n� ve tekrar ba�latma fonksiyonlar�n� ayarlayaca��m sonra �zerine �al���r�z.
}

/** Assignmenttan kalan kodu comment olarak atıyorum dursun burda :D
    bool gameEnd = false;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if(gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("Game Over");
            Invoke("Restart", 0);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    */
