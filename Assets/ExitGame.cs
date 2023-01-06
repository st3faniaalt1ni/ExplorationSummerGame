using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public void exitgame()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();

    }
}