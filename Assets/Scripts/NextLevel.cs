using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void OnPlayHandler()
    {
        SceneManager.LoadScene(2);
    }
    public void OnExitHandler()
    {
        SceneManager.LoadScene(0);
    }
}
