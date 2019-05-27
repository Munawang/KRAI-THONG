using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void QuitGame()
    {
        UnityEngine.Debug.LogError("Game is exiting");
        Application.Quit();
    }
}
