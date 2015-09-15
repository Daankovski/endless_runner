using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	public float carSpeed = 8f;
	public float carVert = 5f;
	Vector3 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
		position.y += Input.GetAxis("Vertical") * carVert * Time.deltaTime;
		transform.position = position;
		//Input.GetAxis("Vertical");
	}
}
