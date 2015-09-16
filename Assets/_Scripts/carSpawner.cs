using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {
	public GameObject car;
	public float maxPos=2.2f;
	public float delayTimer = 2f;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer<=0)
		{
			Vector3 carPos = new Vector3 (Random.Range (-2.25f, 2.2f), transform.position.y, transform.position.z);
			Instantiate (car, carPos, transform.rotation);
			timer = delayTimer;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy(gameObject);
		}
	}
}
