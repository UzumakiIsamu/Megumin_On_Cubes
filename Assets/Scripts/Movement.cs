using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // This is my horizontal (forward) speed
    public float forwardSpeed = 5f;

    // This is my vertical (left-right) speed
    public float leftRightSpeed = 6f;

    public float screenWidth = Screen.width;
    private float horizontal = 0;

    private void FixedUpdate()
    {
        // I read inputs with this function
         float verticalAxis = Input.GetAxis("Horizontal") * leftRightSpeed * Time.deltaTime;

        // Moves the object in the direction and distance of translation.
        transform.Translate(verticalAxis, 0, 0); // For Testing

        transform.Translate(0, 0, forwardSpeed * Time.deltaTime);

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x > screenWidth / 2)
                {
                    horizontal = 1.0f;
                }
                if (touch.position.x < screenWidth / 2)
                {
                    horizontal = -1.0f;
                }
            }
        }
        else
        {
            horizontal = 0.0f;
        }

        transform.Translate(horizontal * leftRightSpeed * Time.deltaTime, 0, 0);
    }
}