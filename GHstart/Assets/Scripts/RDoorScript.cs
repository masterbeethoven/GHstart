using UnityEngine;
using System.Collections;

public class RDoorScript : MonoBehaviour {
	bool open;
	//bool open; open starts out as false. when do first tab, turns true. when true, -Vector3.  
	//public float doorValue = 5000f;
	
	public AudioClip doorOpen;
	public AudioClip doorClose;

	//AudioSource source; 
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (open == false){
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");

				transform.GetComponent<Animation>()["RDoorAnim"].normalizedTime = 1.0f;
				transform.GetComponent<Animation>()["RDoorAnim"].speed = -1.0f;
				transform.GetComponent<Animation>().CrossFade("RDoorAnim");
				//anim was backwards so i'll just deal with it this way
				open=true;	
				if (open ==true){
					GetComponent<AudioSource>().PlayOneShot(doorOpen);
				}
			}
		}
		else{
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");

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
		
		
		
		
	}
}


