using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControler : MonoBehaviour
{
    public bool PaddleIsOnLeft = true;
    public float movementSpeed;

    Rigidbody2D rigidComponent;

    void Start()
    {
        rigidComponent = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        switch (PaddleIsOnLeft)
        {
            case true:
                rigidComponent.velocity = new Vector2(0, Input.GetAxis("Left Paddle Movement") * movementSpeed);
                break;
            
            case false:
                rigidComponent.velocity = new Vector2(0, Input.GetAxis("Right Paddle Movement") * movementSpeed);
                break;
        }
    }
}
