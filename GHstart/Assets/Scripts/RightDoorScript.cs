using UnityEngine;
using System.Collections;

public class RightDoorScript : MonoBehaviour {
	bool open;
	
	
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
				RDoorOpen();
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
		Debug.Log ("Right Door Open");
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
		Debug.Log("Right Door Close");
	}
	
	
	
	//}
}


