using UnityEngine;
using System.Collections;

public class CaneScrapeScript : MonoBehaviour {

	//bool isMoving = false;
	public float min = -5f;
	public float max = 5f;
	public AudioClip clip;
	AudioSource sound;


	// Use this for initialization
	void Start () {
		min=transform.position.x;
		max=transform.position.x+.5f;
		//auto move

		/*if(transform.position.x && transform.position.x+.5f){
			isMoving=true;
			sound=GetComponent<AudioSource>();// sfx of collision
			sound.PlayOneShot(clip);
		}*/
		sound=GetComponent<AudioSource>();// sfx of collision
		sound.PlayOneShot(clip);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X")<0){
			//Code for action on mouse moving left
			print("Mouse moved left");
			//GetComponent<AudioSource>().Play();

		}
		if(Input.GetAxis("Mouse X")>0){
			//Code for action on mouse moving right
			print("Mouse moved right");
		}

		//transform.position =new Vector3(Mathf.PingPong(Time.time*.5f,max-min)+min, transform.position.y, transform.position.z);

	
	}

	void OnCollisionEnter(Collision col){
		if(col.collider.gameObject.tag == "Floor")
			Debug.Log (col.collider.gameObject.tag); //says tag when collide

		//if(rigidbody.velocity.magnitude >0)
			//Debug.Log("move");

	}
}
