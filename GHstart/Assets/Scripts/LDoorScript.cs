using UnityEngine;
using System.Collections;

public class LDoorScript : MonoBehaviour {
	bool open;
	//bool open; open starts out as false. when do first tab, turns true. when true, -Vector3.  
	public float doorValue = 5000f;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (open == false){
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				transform.Rotate(Vector3.up * doorValue * Time.deltaTime);
				open=true;
				
			}
		}
		else{
			if(Input.GetKeyDown(KeyCode.Tab)){
				Debug.Log("tab");
				transform.Rotate(-Vector3.up * doorValue * Time.deltaTime);
				open=false;
			}
		}
	
	

	
	}
}


