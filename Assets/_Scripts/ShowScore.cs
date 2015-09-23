using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	[SerializeField]
	private Text textScore;
	private int endScore;
	
	// Use this for initialization
	void Start () {
		endScore = UIManager.score;
	}
	
	// Update is called once per frame
	void Update () {
		textScore.text = "Oh no! You crashed! You score was: " + endScore;
	}
}
