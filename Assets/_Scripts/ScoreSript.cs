using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreSript : MonoBehaviour {

    public static int score;
    private int scoreTimer;
    public Text scoreText;

	void Start () {
        score = 0;
        scoreTimer = 0;
        SetScoreText();
	}
	
	void Update () {
        if (gameObject.CompareTag("Score")) {

            if (scoreTimer < 20)
            {
                scoreTimer++;

            }
            else if (scoreTimer == 20)
            {
                scoreTimer = 0;
                score = score + 1;
               // Debug.Log(score);
            }

            SetScoreText();
        }
       
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score;
    }


}
