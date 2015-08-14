using UnityEngine;
using System.Collections;

public class FPSScript : MonoBehaviour {

	public float speed = 1.5f;
		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
		/*if(Input.GetKey(KeyCode.W))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.back);
		}*/
		//CharacterController.SimpleMove(Vector3.right*speed IDK WTF
			//everything's backwards bc the camera position got fucked around the house 
		if(Input.GetKey(KeyCode.A))
		{
			transform.position+=Vector3.right*speed *Time.deltaTime;
	
		}

		if(Input.GetKey(KeyCode.D))
		{
			transform.position+=Vector3.left*speed *Time.deltaTime; 
		}

		if(Input.GetKey(KeyCode.W))
		{
			transform.position+=Vector3.back*speed*Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.S))
		{
			transform.position+=Vector3.forward*speed*Time.deltaTime;
		}



	
	}

	 void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Collider")
			Debug.Log("There is something in front of the object!");
	}
}
