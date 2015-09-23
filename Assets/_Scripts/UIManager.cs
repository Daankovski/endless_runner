using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

    private int score;
    private int scoreTimer;
    public Text scoreText;
      

    public void Pause() {
			if (Time.timeScale == 1){
				Time.timeScale = 0;
                   
			}

			else if (Time.timeScale == 0){
				Time.timeScale = 1;
            
			}
    }

	private Button StartM;

    
	void Start () {
		StartM = StartM.GetComponent<Button> ();

        //Score Variables
        score = 0;
        scoreTimer = 0;
        SetScoreText();
        //
    }

    void Update() {
        SetScore();
    }

    void SetScore()
    {
        if (gameObject.CompareTag("Score"))//Looks for an object with a tag that equals Score
        {
            if (scoreTimer < 20 && Time.timeScale != 0)//Makes the scoreTimer count to 20 if the Time.timeScale is not equal to 0 and the game is playing
            {
                scoreTimer += 1;
            }

            else if (scoreTimer == 20)//When the scoreTimer reaches 20 it adds 1 to score
            {
                scoreTimer = 0;
                score = score + 1;
            }

            //Debug.Log(score);
            SetScoreText();
        }
    }

    void SetScoreText() {
        scoreText.text = "Score: " + score;
    }


    public void StartLevel() { 
		Application.LoadLevel ("mainScene");

	}
	
	public void QuitGame() {
		Application.Quit ();
	}

	public void HowTo()	{
		Application.LoadLevel ("HowTo");
	}

	public void Menu() {
		Application.LoadLevel ("Menu");
	}

}

