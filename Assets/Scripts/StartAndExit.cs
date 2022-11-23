using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class StartAndExit : MonoBehaviour
{
    // This function starts the game.
    public void Open()
    {
        SceneManager.LoadScene("Level 1");
    }

    // This function closes the game.
    public void Close()
    {
        //EditorApplication.isPlaying = false; // This is for editing.

        Application.Quit(); // This is for app.
    }
}
