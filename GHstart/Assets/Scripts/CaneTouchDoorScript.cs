using UnityEngine;
using System.Collections;

public class CaneTouchDoorScript : MonoBehaviour {

	public CabinetDoorBehaviorArrayScript lcabinetdoorscript;
	public CabinetDoorBehaviorArrayScript rcabinetdoorscript;
	public DuckScript duckscript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void OnCollisionStay(){
		Debug.Log ("cabinet touch");
		if(Input.GetKeyDown(KeyCode.Tab)){
			Debug.Log ("cabinet tab");
			lcabinetdoorscript.ChangeDoorState();
			rcabinetdoorscript.ChangeDoorState();
		}

//		if(Input.GetKeyDown(KeyCode.Return)){
//			Debug.Log ("Enter for Duck");
			duckscript.CollectDuck();
//
//		}
	}
}

