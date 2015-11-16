using UnityEngine;
using System.Collections;

public class DuckScript : MonoBehaviour {

	public GameObject duck;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CollectDuck();
	
	}

	public void CollectDuck(){
		//Destroy(GameObject.FindWithTag("Duck"));
		//DestroyObject(duck);
		//DestroyImmediate(duck,true);
	}


}
