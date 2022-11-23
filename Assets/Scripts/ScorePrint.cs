using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePrint : MonoBehaviour
{
    public TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + Score.score.ToString();
    }
}
