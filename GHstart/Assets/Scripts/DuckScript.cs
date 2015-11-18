using UnityEngine;
using System.Collections;

public class DuckScript : MonoBehaviour {
	
	bool gotDuck;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gotDuck=false;
		CollectDuck();
	
	}

	public void CollectDuck(){
		if(Input.GetKeyDown(KeyCode.Return)){
			Destroy(GameObject.FindWithTag("Duck"));
			Debug.Log("Got the Duck");
			gotDuck=true;
			Debug.Log("duck true");
			//duckscript.CollectDuck();
			
		}


	}


}
