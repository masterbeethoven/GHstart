using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//increment by 1 
//just index, value i that starts a 0 
//hit tab, element 0 becomes true 

public class TabSoundScript : MonoBehaviour { 

	public AudioClip voiceClip; 

	public string[] menuOptions = new string [4]; 
	private int pointer = 0;

	// Use this for initialization
	void Start () {
		menuOptions[0]="Gone Home";
		menuOptions[1]="New Game";
		menuOptions[2]="Options";
		menuOptions[3]="Exit";
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("check");
		if(Input.GetKeyDown (KeyCode.Tab)){
			//Debug.Log ("Tab Down");
			changeAudio();
		}
		if(Input.GetKeyDown (KeyCode.Return)){
			Debug.Log ("Enter");
			changeScene();
		}

		/*if(Input.GetKey(KeyCode.Tab))
		{
			GetComponent<AudioSource>().PlayOneShot(audio);
			GetComponent<AudioSource>().Play ();
	
		}
		if (Input.GetKey("up"))
			print("up arrow key is held down");
		
		if (Input.GetKey("down"))
			print("down arrow key is held down");*/
	}

	void changeAudio()
	{
		pointer ++;
		if(pointer > 3){
			pointer = 0;
		}
		GameObject.Find (menuOptions[pointer]).SendMessage ("PlaySound");

	}
	void changeScene()
	{
		Application.LoadLevel(menuOptions[pointer]);
	}

}



