using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	//Animator animator;
	public Rect openDoorRectangle;
	public Rect closeDoorRectangle;
	public Animator animator;


/*
	void Start () 
	{
		animator = GetComponent <Animator>();
	}*/
	

/*	void OnGUI () 
	{
		if (GUILayout.Button("Open Door"))
		{
			animator.SetInteger ("Door Close", 0);
			animator.SetInteger ("Door Open", 1);
		}



		if (GUILayout.Button("Close Door"))
		{
			animator.SetInteger ("Door Close", 1);
			animator.SetInteger ("Door Open", 0);
		}
	}*/

	void OnGUI ()
	{
		if(GUI.Button (openDoorRectangle, "Open Door"))
		{
			animator.SetInteger ("Door Open", 1);
			animator.SetInteger ("Door Close", 0);
		}

		if(GUI.Button (closeDoorRectangle, "Close Door"))
		{
			animator.SetInteger ("Door Open", 0);
			animator.SetInteger ("Door Close", 1);
		}
	}


}
