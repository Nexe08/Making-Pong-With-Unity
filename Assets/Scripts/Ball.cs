using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject scoreManager;
    public Rigidbody2D rigidComponent;
    public float movementSpeed;
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

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("leftBallDetector")) {
            scoreManager.GetComponent<ScoreManager>().RightPlayerScore++;
        }

        if (other.gameObject.tag.Equals("rightBallDetector")) {
            scoreManager.GetComponent<ScoreManager>().LeftPlayerScore++;
        }
    }
}
