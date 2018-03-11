using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLightWithMouse : MonoBehaviour {
	public GameObject light;
	private bool on = false;

	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				if (!on)
				{
					light.SetActive(true);
					on = true;
				}
				else if (on)
				{
					light.SetActive(false);
					on = false;
				}
			}
		}
	}
}
