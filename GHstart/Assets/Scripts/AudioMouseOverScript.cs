using UnityEngine;
using System.Collections;

public class AudioMouseOverScript : MonoBehaviour {

	public AudioClip test;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		Debug.Log("works");
		GetComponent<AudioSource>().PlayOneShot(test);
		GetComponent<AudioSource>().Play ();


	}
}
