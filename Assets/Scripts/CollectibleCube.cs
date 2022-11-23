using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CollectibleCube : MonoBehaviour
{
    bool isCollected; // This checks cube is collected or not.
    float index; // Index of cube
    public CollectorCube collector; // Collector cube object.

    void Start()
    {
        isCollected = false; // At start, it is not collected;
    }

    void Update()
    {
        // This condition checks this cube is collected or not.

        if(isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    // This function returns the value of isCollected
    public bool GetIsCollected()
    {
        return isCollected;
    }

    // This function sets isCollected variable to true.
    public void SetIsCollected()
    {
        isCollected = true;
    }

    // This function sets index of this collectible cube.
    public void SetIndex(float i)
    {
        index = i;
    }

    private void OnTriggerEnter(Collider other)
    {
        // This condition checks this collectible object hits to the barrier or not.
        if(other.gameObject.tag == "Barrier")
        {
            collector.DecreaseHeight(1);

            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
