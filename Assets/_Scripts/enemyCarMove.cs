using UnityEngine;
using System.Collections;

public class enemyCarMove : MonoBehaviour {

	private int speed; 

	// Use this for initialization
	void Start () {
		speed = Random.Range(5,10);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
}
