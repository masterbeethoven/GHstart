using UnityEngine;
using System.Collections;

public class RayCastScript : MonoBehaviour {


	RaycastHit hit;
	Ray ray; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit))
		{
			print (hit.collider.name);
		}
		/*Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, out hit, 10))
			if(hit.collider !=null)
			Debug.Log(hit.collider.gameObject.name);*/
				
			//print ("front");
	}
}
