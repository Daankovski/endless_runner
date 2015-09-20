using UnityEngine;
using System.Collections;

public class enemyCarMove : MonoBehaviour {

	private int speed; 
	private int minSpeed = 5;
	private int maxSpeed = 10;

	// Use this for initialization
	void Start () {
		speed = Random.Range(minSpeed,maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
}
