using UnityEngine;
using System.Collections;

public class CaneContactScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(){
		Debug.Log ("bang");
		GetComponent<AudioSource>().Play ();

	}
}
