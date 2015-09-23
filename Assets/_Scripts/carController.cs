using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	[SerializeField]
	private float carSpeed = 5f;
	[SerializeField]
	private float carVert = 1f;

	[SerializeField]
    private float maxTop;
	[SerializeField]
    private float maxBot;
	[SerializeField]
    private float maxLeft;
	[SerializeField]
    private float maxRight;

	[SerializeField]
	private Animator anim;
	[SerializeField]
	private Animation anim2;

	[SerializeField]
	private static float deathTimer = 1f;
	[SerializeField]
	private static bool isHit = false;
	[SerializeField]
	private int crashCount = 0;

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
			anim.SetBool ("heal1", false);
			anim.SetBool ("heal2", false);
			crashCount += 1;
			//Destroy(gameObject);
		} else if (col.gameObject.tag == "Enemy" && crashCount == 1) {
			anim.SetBool ("stage2", true);
			anim.SetBool ("heal1", false);
			anim.SetBool ("heal2", false);
			crashCount += 1;
		} else if (col.gameObject.tag == "Enemy" && crashCount == 2) {
			anim.SetBool ("death", true);
			crashCount += 1;
			isHit = true;
		} else if (col.gameObject.tag == "PickUp" && crashCount == 1){
			anim.SetBool ("heal1", true);
			anim.SetBool ("stage1",false);
			crashCount =0;

		}else if (col.gameObject.tag == "PickUp" && crashCount == 2){
			anim.SetBool ("heal2", true);
			anim.SetBool ("stage2", false);
			crashCount = 1;

		}
		 if (col.gameObject.name == "item5(Clone)") {
			Destroy(col.gameObject);
		}
	}
	void GameOver(){
		if (isHit == true) {
			deathTimer -= Time.deltaTime;
            Application.LoadLevel("GameOver");
            crashCount = 0;

            if (deathTimer <= 0){
				if (Time.timeScale == 1){
					Time.timeScale = 0;
				}
			}
		}
	}
}