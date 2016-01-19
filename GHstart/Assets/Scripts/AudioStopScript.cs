using UnityEngine;
using System.Collections;

public class AudioStopScript : MonoBehaviour {

	AudioSource sound;
	bool isPlaying;

	// Use this for initialization
	void Start () {

		sound = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			sound.Stop();
			isPlaying=false;
			Debug.Log ("stop");

		}

	
	}
}
