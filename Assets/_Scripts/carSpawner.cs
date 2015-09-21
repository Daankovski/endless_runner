using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {
	public GameObject[] cars;
	private int carNo;
	[SerializeField]
    private float maxPos;
    public float minPos;
    public float delayTimer;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
        if (timer <= 0 && gameObject.tag == "SpawnTop")
		{
			Vector3 carPos = new Vector3 (Random.Range (maxPos, minPos), transform.position.y, transform.position.z);
			carNo = Random.Range(0,6);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}
		else if (timer <= 0 && gameObject.tag == "SpawnBot")
		{
			Vector3 carPos = new Vector3 (Random.Range (minPos, maxPos), transform.position.y, transform.position.z);
			carNo = Random.Range(0,6);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}
	}
}