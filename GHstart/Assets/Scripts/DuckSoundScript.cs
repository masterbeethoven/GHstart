using UnityEngine;
using System.Collections;

public class DuckSoundScript : MonoBehaviour {
	public AudioClip ahKey;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			GetComponent<AudioSource> ().PlayOneShot (ahKey);
		}
	
	}
}
