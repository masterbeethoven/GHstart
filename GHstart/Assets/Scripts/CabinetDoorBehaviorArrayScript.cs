using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CabinetDoorBehaviorArrayScript : MonoBehaviour {


	public Animation[] doorOptions = new Animation[4]; 
	private int pointer = -1;
	//LDoorScript Name = new LDoorScript();


	// Use this for initialization
	void Start () {
		LDoorScript lOpen = gameObject.GetComponent<LDoorScript>();
		lOpen.LDoorOpen();

		LDoorScript lClose = gameObject.GetComponent<LDoorScript>();
		lClose.LDoorClose();

		RDoorScript rOpen = gameObject.GetComponent<RDoorScript>();
		rOpen.RDoorOpen();

		RDoorScript rClose = gameObject.GetComponent<RDoorScript>();
		rClose.RDoorClose();

	
//		doorOptions[0]= LDoorAnim;//"Left Door Open"
//		doorOptions[1]= "RDoorAnim";
//		doorOptions[2]= "LDoorAnim";
//		doorOptions[3]= "RDoorAnim;";

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)){
			ChangeDoorState();
		}



	}

	public void ChangeDoorState(){

		pointer ++;
		if(pointer > 3){
			pointer = 0;
		}
		//each array corresponds to the open/close functions from LDoorScript and RDoorScript 
		//GameObject.Find (doorOptions[pointer]).SendMessage ("LDoorOpen");





	}
}
