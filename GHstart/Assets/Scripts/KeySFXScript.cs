using UnityEngine;
using System.Collections;

public class KeySFXScript : MonoBehaviour {
	public AudioClip keyJingle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftShift)|| Input.GetKeyDown(KeyCode.RightShift)) {
			GetComponent<AudioSource> ().PlayOneShot (keyJingle);
		}
		
	}
}
