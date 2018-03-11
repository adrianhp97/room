﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				InteractiveObject obj = hit.collider.GetComponent<InteractiveObject>();
				if(obj)
				{
					obj.TriggerInteraction();
				}
			}
		}
	}
}