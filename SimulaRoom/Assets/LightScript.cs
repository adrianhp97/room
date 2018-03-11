using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {
	public Light Light;
	private bool isOn;

	void OnMouseDown () {
		if (isOn) {
			isOn = false;
			Light.enabled = false;
		}
		else if (!isOn) {
			isOn = true;
			Light.enabled = true;
		}
	}
}
