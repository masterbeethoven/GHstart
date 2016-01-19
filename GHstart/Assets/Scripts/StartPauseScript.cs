using UnityEngine;
using System.Collections;

public class StartPauseScript : MonoBehaviour {

	 GameObject fpscontroller;
	
	void Start() {
		StartCoroutine(Example());
	}
	
	IEnumerator Example() {
		print(Time.time);
		gameObject.SetActive(false);
		//fpscontroller=gameObject.GetComponent<GameObject>();
		yield return new WaitForSeconds(5);
		gameObject.SetActive(true);
		print(Time.time);
	}
	
}