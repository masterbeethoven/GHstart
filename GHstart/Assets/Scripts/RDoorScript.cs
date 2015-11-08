using UnityEngine;
using System.Collections;

public class RDoorScript : MonoBehaviour {
	bool open; // open starts out as false. when do first tab, turns true. when true, -Vector3.  
	//public float doorValue = 5000f;
	LDoorScript Name = new LDoorScript();
	public AudioClip doorOpen;
	public AudioClip doorClose;

	//AudioSource source; 
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (open == false && GameObject.FindWithTag("RDoor")){
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				RDoorOpen();

			}
			if (open==true && GameObject.FindWithTag("RDoor")){
				
				Name.LDoorOpen();
				Debug.Log("hey!");
			}
		}

		else {
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				RDoorClose();

			}
		}

	}

	public void RDoorOpen(){
		transform.GetComponent<Animation>()["RDoorAnim"].normalizedTime = 1.0f;
		transform.GetComponent<Animation>()["RDoorAnim"].speed = -1.0f;
		transform.GetComponent<Animation>().CrossFade("RDoorAnim");
		//anim was backwards so i'll just deal with it this way
		open=true;	
		if (open ==true){
			GetComponent<AudioSource>().PlayOneShot(doorOpen);
		}
	}

	public void RDoorClose(){
		transform.GetComponent<Animation>()["RDoorAnim"].normalizedTime = 0.0f;
		transform.GetComponent<Animation>()["RDoorAnim"].speed = 1.0f;
		transform.GetComponent<Animation>().CrossFade("RDoorAnim");
		GetComponent<Animation>().Play("RDoorAnim");
		open=false;
		if(open==false){
			GetComponent<AudioSource>().PlayOneShot(doorClose);
		}
	}


}



