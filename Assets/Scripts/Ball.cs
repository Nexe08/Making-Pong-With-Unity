using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rigidComponent;

    Vector2 velocity;
    void Start()
    {
        float direction = Random.Range(-1, 1);

        if (direction < 0)
        {
            rigidComponent.AddForce(new Vector2(-movementSpeed,
                Random.Range(-movementSpeed * .5f, movementSpeed * .5f)), ForceMode2D.Force);
        }
        else {
            rigidComponent.AddForce(new Vector2(movementSpeed,
                Random.Range(-movementSpeed * .5f, movementSpeed * .5f)), ForceMode2D.Force);
        }
    }
}
