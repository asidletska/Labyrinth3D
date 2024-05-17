using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject endGame;
    public Transform player;

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {        
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
