using UnityEngine;
using System.Collections;

public class Crouch : MonoBehaviour {
	public CharacterController crouchController;
	private float height;
	private Transform tr;

	void Start ()
	{
		tr = transform;
		height = crouchController.height;
	}

	void Update ()
	{
		float h = height;
		if ( Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.LeftControl) )
		{
			h = 0.5f * height;
		}
		float lastHeight = crouchController.height; // crouch/stand up smoothly 
		crouchController.height = Mathf.Lerp( crouchController.height, h, 5.0f * Time.deltaTime );
		tr.position += new Vector3( 0, ( crouchController.height - lastHeight ) * 0.5f, 0 ); // fix vertical position
	}
}
