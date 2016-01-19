using UnityEngine;
using System.Collections;

public class MouseCenteredScript : MonoBehaviour {

	CursorLockMode lockMode;

	// Apply requested cursor state
	void SetCursorState ()
	{
		Cursor.lockState = lockMode;
		// Hide cursor when locking
		//Cursor.visible = (CursorLockMode.Locked != wantedMode);
	}
	
	void OnGUI ()
	{
		GUILayout.BeginVertical ();
		// Release cursor on escape keypress
		if (Input.GetKeyDown (KeyCode.Escape))
			Cursor.lockState = lockMode = CursorLockMode.None; //used to be /None
		
		switch (Cursor.lockState)
		{

		case CursorLockMode.Locked:
			GUILayout.Label ("Cursor is locked");
			if (GUILayout.Button ("Unlock cursor"))
				lockMode = CursorLockMode.None;
			break;

		case CursorLockMode.None:
			GUILayout.Label ("Cursor is normal");
			if (GUILayout.Button ("Lock cursor"))
				lockMode = CursorLockMode.Locked;
			break;
		}
		
		GUILayout.EndVertical ();
		
		SetCursorState ();
	}

	// Use this for initialization
	void Start () {
	
		//Cursor.lockState = CursorLockMode.Locked;
		lockMode = CursorLockMode.Locked;

	}
	
	// Update is called once per frame
	void Update () {

	}
}
