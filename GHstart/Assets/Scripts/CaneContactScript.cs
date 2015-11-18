using UnityEngine;
using System.Collections;

public class CaneContactScript : MonoBehaviour {
	
	private const float delay = 2; // Delay between playing sound
	
	public AudioClip clip;
	AudioSource sound;
	private float timeOfLastPlay;


	// Use this for initialization
	void Start () {

		sound = GetComponent<AudioSource>();
		//timeOfLastPlay = -1 * delay;

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter(){
		//void OnCollisionStay(){

		Debug.Log ("cane touch");

//		float currentTime = Time.time;
//		if ((currentTime - timeOfLastPlay) > delay) {
//			//Debug.Log ("bang");
			sound.Play();
			sound.PlayOneShot(clip);
//			timeOfLastPlay = currentTime;
//		}
	}

	//}

	void OnCollisionExit(){
		sound.Stop();
	}

}




