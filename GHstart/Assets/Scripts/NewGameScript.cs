using UnityEngine;
using System.Collections;

public class NewGameScript : MonoBehaviour {

	public AudioClip testchime; 

	void OnMouseOver(){

		Debug.Log("works");
		audio.PlayOneShot(testchime);
		audio.Play ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
