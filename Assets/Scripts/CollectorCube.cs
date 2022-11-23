using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class CollectorCube : MonoBehaviour
{
    GameObject mainCube; // Main Cube Object
    public float height; // Height of this cube

    [SerializeField]
    private Movement move;

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private GameObject winnerPanel;

    void Start()
    {
        mainCube = GameObject.Find("MainCube");

        gameOverPanel.SetActive(false);
        winnerPanel.SetActive(false);
    }

    // This function updates this cubes position per frame.
    void Update()
    {
        //mainCube.transform.position = new Vector3(transform.position.x, height, transform.position.z);

        mainCube.transform.DOMoveY(height, 1.7f);

        transform.localPosition = new Vector3(0, -height, 0);
    }

    // This function decreases height of this cube.
    public void DecreaseHeight(float i)
    {
        height-= i;
        Debug.Log("Height: " + height);
    }

    private void OnTriggerEnter(Collider other)
    {
        // This condition checks this cube hit a collectible cube or not.
        if(other.gameObject.tag == "Collectible" && other.gameObject.GetComponent<CollectibleCube>().GetIsCollected() == false)
        {
            height += 1;
            Debug.Log("Height: " + height);
            other.gameObject.GetComponent<CollectibleCube>().SetIsCollected();
            other.gameObject.GetComponent<CollectibleCube>().SetIndex(height);

            other.gameObject.transform.parent = mainCube.transform;
        }

        // This condition checks this cube hits barrier or not.
        if (other.gameObject.tag == "Barrier")
        {
            move.leftRightSpeed = 0;
            move.forwardSpeed = 0;
            anim.SetBool("isLosing", true);
            gameOverPanel.SetActive(true);
        }

        // This condition checks this cube is in finish line or not.
        if (other.gameObject.tag == "Finish Line")
        {
            move.leftRightSpeed = 0;
            move.forwardSpeed = 0;
            anim.SetBool("isWinning", true);
            winnerPanel.SetActive(true);
        }
    }
}
