using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeguminHit : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    [SerializeField]
    private Movement move;

    [SerializeField]
    private GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // This function checks the player (Megumin) hits the barrier or not.
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Barrier")
        {
            move.forwardSpeed = 0;
            move.leftRightSpeed = 0;
            anim.SetBool("isLosing", true);
            gameOverPanel.SetActive(true);
        }
    }
}
