using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    // This function restarts the level.
    public void YouWin()
    {
        if(Score.levelCounter == 1)
        {
            Score.levelCounter++;
            SceneManager.LoadScene("Level " + Score.levelCounter.ToString());
        }

        else if(Score.levelCounter == 2)
        {
            Score.levelCounter--;
            SceneManager.LoadScene("Level " + Score.levelCounter.ToString());
        }
    }
}
