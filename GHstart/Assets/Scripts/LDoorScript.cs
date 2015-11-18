using UnityEngine;
using System.Collections;

public class LDoorScript : MonoBehaviour {
	bool open;
	bool rDoor; // right door starts out false. 
	//bool open; open starts out as false. when do first tab, turns true. when true, -Vector3.  
	//public float doorValue = 5000f;


	public AudioClip doorOpen;
	public AudioClip doorClose;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionStay(){
		if (open == false){
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				LDoorOpen();
			}
			
		}
		
		
		else {
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				LDoorClose();
				
			}
		}


	}



	public void LDoorOpen(){
		transform.GetComponent<Animation>()["LDoorAnim"].normalizedTime = 0.0f;
		transform.GetComponent<Animation>()["LDoorAnim"].speed = 1.0f;
		transform.GetComponent<Animation>().CrossFade("LDoorAnim");
		GetComponent<Animation>().Play("LDoorAnim");
			open=true;	
			if (open ==true){
				//GetComponent<AudioSource>().Play();
				GetComponent<AudioSource>().PlayOneShot(doorOpen);
			}
	}

	public void LDoorClose(){
		transform.GetComponent<Animation>()["LDoorAnim"].normalizedTime = 1.0f;
		transform.GetComponent<Animation>()["LDoorAnim"].speed = -1.0f;
		transform.GetComponent<Animation>().CrossFade("LDoorAnim");
		GetComponent<Animation>().Play("LDoorAnim");
			open=false;
			if(open==false){
				GetComponent<AudioSource>().PlayOneShot(doorClose);
			}

	}
	

	
	//}
}


