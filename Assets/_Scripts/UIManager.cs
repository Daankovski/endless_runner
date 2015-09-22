using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

    public void Pause(){
			if (Time.timeScale == 1){
				Time.timeScale = 0;
//			GetComponent<AudioSource>("AmbulanceSiren").audio.Pause();
			//((AudioSource)GameObject.Find("car").GetComponent("AmbulaceSiren")).audio.Pause();
			}
			else if (Time.timeScale == 0){
				Time.timeScale = 1;
	//		GetComponent<AudioSource>("AmbulanceSiren").audio.Play();
			//((AudioSource)GameObject.Find("car").GetComponent("AmbulaceSiren")).audio.Play();
			}
		}
	public Button StartM;
	void Start () 
	{
		StartM = StartM.GetComponent<Button> ();
    }
	
	public void StartLevel()
	{
		Application.LoadLevel ("mainScene");
		
	}
	
	public void QuitGame()
	{
		Application.Quit ();
	}

	public void HowTo()
	{
		Application.LoadLevel ("HowTo");
	}

	public void Menu()
	{
		Application.LoadLevel ("Menu");
	}
}

