using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	public float carSpeed = 8f;
	public float carVert = 5f;

    public float maxTop;
    public float maxBot;
    public float maxLeft;
    public float maxRight;

	public Animator anim;
	public Animation anim2;

	public static float deathTimer = 2f;
	public static bool isHit = false;
	public int crashCount = 0;

	Vector3 position;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
		position.y += Input.GetAxis("Vertical") * carVert * Time.deltaTime;

		position.x=Mathf.Clamp(position.x,maxLeft,maxRight);
		position.y=Mathf.Clamp(position.y,maxBot,maxTop);	

		transform.position = position;
		//Input.GetAxis("Vertical");

		GameOver ();
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy" && crashCount == 0) {
			anim.SetBool ("stage1", true);
			crashCount += 1;
			//Destroy(gameObject);
		} else if (col.gameObject.tag == "Enemy" && crashCount == 1) {
			anim.SetBool ("stage2", true);
			crashCount += 1;
		}else if (col.gameObject.tag == "Enemy" && crashCount == 2) {
			anim.SetBool ("death", true);
			crashCount += 1;
			isHit = true;
		}
	}

	void GameOver(){
		if (isHit == true) {
			deathTimer -= Time.deltaTime;
			Debug.Log (deathTimer);
			
			if (deathTimer <= 0){
				if (Time.timeScale == 1){
					Time.timeScale = 0;
				}
			}
		}
	}
}