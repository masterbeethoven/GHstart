using UnityEngine;
using System.Collections;

public class AudioTest : MonoBehaviour {

	public AudioClip sound1;
	public AudioClip sound2;
	AudioSource audio;

	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X")<0){
			if (!audio.isPlaying) {
				audio.clip = sound1;
				audio.Play();
			}
		}

		if(Input.GetAxis("Mouse X")>0){
			if (!audio.isPlaying){
				audio.clip = sound2;
				audio.Play();
			}
		}

	
	}


}
