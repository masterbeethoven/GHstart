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
	RightDoorScript rightdoorscript;
	LDoorScript ldoorscript;

	bool isLeft = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}

	public void ChangeDoorState(){ //canetouchdoorscript 
		//OPENS
		if(isLeft){ //LEFT
			isLeft = false;
			AnimationState lDoor = transform.GetComponent<Animation>()["LDoorAnim"];

			if(lDoor != null){//left open
				lDoor.normalizedTime = 0.0f;
				lDoor.speed = 1.0f;
				transform.GetComponent<Animation>().CrossFade("LDoorAnim");
				GetComponent<Animation>().Play("LDoorAnim");
				Debug.Log ("left open");
				isOpen=true;
				//isOpen=true; //edit here too. maybe else statement within this like the specific door scripts plus stating dont until right open.
			}
			isOpen=true;
			//isLeft=true; //not here origin. this makes it flip out.
			if(isOpen==true){
				GetComponent<AudioSource>().PlayOneShot(doorOpen);
			}

			isLeft = true; //RIGHT
			AnimationState rDoor = transform.GetComponent<Animation>()["RDoorAnim"];
			
			if(rDoor !=null){//right open
				rDoor.normalizedTime = 1.0f; 
				rDoor.speed = -1.0f; 
				transform.GetComponent<Animation>().CrossFade("RDoorAnim");
				//anim was backwards so i'll just deal with it this way
				GetComponent<Animation>().Play("RDoorAnim");
				Debug.Log ("right open");
				isOpen=true;
			}
			isOpen=true;	
			if (isOpen ==true){
				GetComponent<AudioSource>().PlayOneShot(doorOpen);

		} 
			//CLOSES
		else { //RIGHT
				isOpen=false;
				ldoorscript.LDoorClose();
				rightdoorscript.RDoorClose();
			}

			//closing codes
//				if(isLeft){ //LEFT
//					isLeft = true; //said false orgin
//					isOpen= true; //said true orign
//					AnimationState lDoor = transform.GetComponent<Animation>()["LDoorAnim"];
//					
//					if(lDoor != null){//left close
//						lDoor.normalizedTime = 1.0f;
//						lDoor.speed = -1.0f;
//						transform.GetComponent<Animation>().CrossFade("LDoorAnim");
//						GetComponent<Animation>().Play("LDoorAnim");
//						Debug.Log ("left closed");
//					}
//					isOpen=false;
//					if(isOpen==false){
//					GetComponent<AudioSource>().PlayOneShot(doorClose);
//					}
//				}
//			else{ //right close
//				isLeft=false; //said true origin
//				isOpen=false;
//				AnimationState rightDoor = transform.GetComponent<Animation>()["RDoorAnim"];
//
//				if(rightDoor !=null){//right close
//					rightDoor.normalizedTime = 0.0f; 
//					rightDoor.speed = 1.0f; 
//					transform.GetComponent<Animation>().CrossFade("RDoorAnim");
//					GetComponent<Animation>().Play("RDoorAnim");
//					Debug.Log ("right closed");
//
//			}
//
//		}
//		/edit here. what happens: cane touch, ldoor opens, tab again, rdoor opens and ldoor closes at same time, keeps closing.
//		if(isLeft){ //LEFT
//			isLeft = false;
//			isOpen= true;
//			AnimationState lDoor = transform.GetComponent<Animation>()["LDoorAnim"];
//			
//			if(lDoor != null){//left open
//				lDoor.normalizedTime = 1.0f;
//				lDoor.speed = -1.0f;
//				transform.GetComponent<Animation>().CrossFade("LDoorAnim");
//				GetComponent<Animation>().Play("LDoorAnim");
//				Debug.Log ("left closed");
//			}
//		} //with this editied out, works on the opening, doesn't close


		}
	}
}
