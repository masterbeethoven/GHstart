using UnityEngine;
using System.Collections;

public class LDoorScript : MonoBehaviour {
	bool open;
	//bool open; open starts out as false. when do first tab, turns true. when true, -Vector3.  
	//public float doorValue = 5000f;

	public AudioClip doorOpen;
	public AudioClip doorClose;
	public Animation LDoorAnims;
	//AudioSource source; 

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (open == false){
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				transform.GetComponent<Animation>()["LDoorAnim"].normalizedTime = 0.0f;
				transform.GetComponent<Animation>()["LDoorAnim"].speed = 1.0f;
				transform.GetComponent<Animation>().CrossFade("LDoorAnim");
				//transform.Rotate(Vector3.up *doorValue* Time.deltaTime);
				GetComponent<Animation>().Play("LDoorAnim");

				open=true;	
					if (open ==true){
						//GetComponent<AudioSource>().Play();
						GetComponent<AudioSource>().PlayOneShot(doorOpen);
					}
			}
		}
		else{
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				//transform.Rotate(-Vector3.up * doorValue* Time.deltaTime);
				//transform.Rotate(Vector3.down * doorValue* Time.deltaTime);
				transform.GetComponent<Animation>()["LDoorAnim"].normalizedTime = 1.0f;
				transform.GetComponent<Animation>()["LDoorAnim"].speed = -1.0f;
				transform.GetComponent<Animation>().CrossFade("LDoorAnim");
				//GetComponent<Animation>().Play("CloseLDoorAnim");
				open=false;
					if(open==false){
					//yield WaitForSeconds(1f);
					GetComponent<AudioSource>().PlayOneShot(doorClose);
					}
			}
		}
	
	

	
	}
}


