using UnityEngine;
using System.Collections;

public class carSpawnerBot : MonoBehaviour {
	public GameObject[] cars;
	int carNo;
	public float maxPos=2.25f;
	public float delayTimer = 2f;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer<=0/* gameObject.tag == (SpawnTop)*/)
		{
			Vector3 carPos = new Vector3 (Random.Range (0.55f,2.25f), transform.position.y, transform.position.z);
			carNo = Random.Range(0,5);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}
		/*else if(timer<=0,gameObject.tag == "SpawnBot")
		{
			Vector3 carPos = new Vector3 (Random.Range (-0.45, 2.25f), transform.position.y, transform.position.z);
			carNo = Random.Range(0,5);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}*/
	}
}