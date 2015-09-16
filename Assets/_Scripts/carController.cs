using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	public float carSpeed = 8f;
	public float carVert = 5f;
	public float maxPos = 2.2f;
	Vector3 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
		position.y += Input.GetAxis("Vertical") * carVert * Time.deltaTime;

		position.x=Mathf.Clamp(position.x,-2.2f,2.2f);
		position.y=Mathf.Clamp(position.y,-5.6f,3.4f);	

		transform.position = position;
		//Input.GetAxis("Vertical");
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			Destroy(gameObject);
		}
	}
}
