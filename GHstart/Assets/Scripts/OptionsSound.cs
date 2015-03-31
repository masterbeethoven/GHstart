using UnityEngine;
using System.Collections;

public class OptionsSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void PlaySound(){
		Debug.Log(this.gameObject.name);
		this.GetComponent<AudioSource>().Play();
	}
}
