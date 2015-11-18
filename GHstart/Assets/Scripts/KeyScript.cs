using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {

	bool gotKey;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gotKey=false;
		CollectKey();
		
	}
	
	public void CollectKey(){
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			Destroy(GameObject.FindWithTag("Key"));
			Debug.Log("Got the Key");
			gotKey=true;
			Debug.Log("key true");
			
		}
		
		
	}
	
	
}
