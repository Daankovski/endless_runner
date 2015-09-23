using UnityEngine;
using System.Collections;

public class PlayerInputs : MonoBehaviour {

	public int playerNumber;
	
	public float x{
		get{
			return Input.GetAxis(string.Format("Player{0}X",playerNumber));
		}
	}

	public float y{
		get{
			return Input.GetAxis(string.Format("Player{0}Y", playerNumber));
		}
	}


}
