using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTVBox : MonoBehaviour {
	public string[] dialogue = {"This is a Television.\nPress Enter...",
		"You can watch a movie with this.\nPress Enter...",
		"Don't throw this Television,\nPress Enter...",
		"Because it can break easily.\nPress Enter..."};
	int index = 999;
	Rect dialogueRect = new Rect(150,220,500,50);


	void Update() {
		if (Input.GetKeyDown("return")) 
		{
			index++;
		} 
	}

	void OnGUI() {
		if((Event.current.Equals(Event.KeyboardEvent ("E")))) {
			index = 0;
			GUI.Box(dialogueRect, dialogue[index]);
		}
		if (index < dialogue.Length) {
			GUI.Box(dialogueRect, dialogue[index]);
		} else {
		}
	}
}
