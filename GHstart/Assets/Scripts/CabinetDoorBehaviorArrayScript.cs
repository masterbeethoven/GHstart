using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CabinetDoorBehaviorArrayScript : MonoBehaviour {

	//old
//	public Animation[] doorOptions = new Animation[4]; 
//	private int pointer = -1;
	//old
	public Animation LDoorAnim;
	public Animation RDoorAnim;
	bool isOpen = false;
	public AudioClip doorOpen;
	public AudioClip doorClose;

	bool isLeft = true;

	// Use this for initialization
	void Start () {

		//old 
//		LDoorScript lOpen = gameObject.GetComponent<LDoorScript>();
//		lOpen.LDoorOpen();
//
//		LDoorScript lClose = gameObject.GetComponent<LDoorScript>();
//		lClose.LDoorClose();
//
//		RDoorScript rOpen = gameObject.GetComponent<RDoorScript>();
//		rOpen.RDoorOpen();
//
//		RDoorScript rClose = gameObject.GetComponent<RDoorScript>();
//		rClose.RDoorClose();
		//old

	
//		doorOptions[0]= LDoorAnim;//"Left Door Open"
//		doorOptions[1]= "RDoorAnim";
//		doorOptions[2]= "LDoorAnim";
//		doorOptions[3]= "RDoorAnim;";

	
	}
	
	// Update is called once per frame
	void Update () {






	}

	public void ChangeDoorState(){
		//ldoor 

		if(isLeft){ //LEFT
			isLeft = false;
			AnimationState lDoor = transform.GetComponent<Animation>()["LDoorAnim"];

			if(lDoor != null){
				lDoor.normalizedTime = 0.0f;
				lDoor.speed = 1.0f;
				transform.GetComponent<Animation>().CrossFade("LDoorAnim");
				GetComponent<Animation>().Play("LDoorAnim");
				Debug.Log ("left");
			}
		} else { //RIGHT
			isLeft = true;
			AnimationState rDoor = transform.GetComponent<Animation>()["RDoorAnim"];

			if(rDoor !=null){
				rDoor.normalizedTime = 1.0f; 
				rDoor.speed = -1.0f; 
				transform.GetComponent<Animation>().CrossFade("RDoorAnim");
				//anim was backwards so i'll just deal with it this way
				GetComponent<Animation>().Play("RDoorAnim");
				Debug.Log ("right");
			}
			isOpen=true;	
			if (isOpen ==true){
				//GetComponent<AudioSource>().Play();
				GetComponent<AudioSource>().PlayOneShot(doorOpen);
			}
		}

	}
}
