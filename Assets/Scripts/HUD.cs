using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public GameObject scoreManager;
    public Text leftScoreText;
    public Text rightScoreText;

    private void Update() {
        leftScoreText.text = scoreManager.GetComponent<ScoreManager>().LeftPlayerScore.ToString();
        rightScoreText.text = scoreManager.GetComponent<ScoreManager>().RightPlayerScore.ToString();
    }
}
