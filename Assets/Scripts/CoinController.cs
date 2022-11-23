using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Our Score Object (Empty Object)
    GameObject score;
    private void Start()
    {
        // This function helps us to find score object
        score = GameObject.Find("ScoreCounter");
        DontDestroyOnLoad(score);
    }

    // This function checks the coin type and take action despite of that.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CollectorCube" && transform.gameObject.tag == "CopperCoin")
        {
            Score.score++;
            Debug.Log("Score:" + Score.score);
            Destroy(transform.gameObject);
        }

        if (other.gameObject.name == "CollectorCube" && transform.gameObject.tag == "SilverCoin")
        {
            Score.score += 2;
            Debug.Log("Score:" + Score.score);
            Destroy(transform.gameObject);
        }

        if (other.gameObject.name == "CollectorCube" && transform.gameObject.tag == "GoldCoin")
        {
            Score.score += 4;
            Debug.Log("Score:" + Score.score);
            Destroy(transform.gameObject);
        }
    }
}
