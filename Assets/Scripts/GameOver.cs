using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // This function restart the level.
    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
        Score.score = 0;
    }
}
