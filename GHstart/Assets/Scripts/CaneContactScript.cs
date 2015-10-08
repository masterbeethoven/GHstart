using UnityEngine;
using System.Collections;

public class CaneContactScript : MonoBehaviour {

	public AudioClip clip;
	AudioSource sound;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(){
		Debug.Log ("bang");
		GetComponent<AudioSource>().Play(); //VO of object
	

		sound=GetComponent<AudioSource>();// sfx of collision
		sound.PlayOneShot(clip);


	}
}
