using UnityEngine;
using System.Collections;

public class roadController : MonoBehaviour {

	public float roadSpeed;
	Vector2 offset;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		offset = new Vector2 (0, Time.time * roadSpeed);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
