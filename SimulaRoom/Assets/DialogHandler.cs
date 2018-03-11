using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHandler : MonoBehaviour {
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				DialogObject obj = hit.collider.GetComponent<DialogObject >();
				if(obj)
				{
					obj.TriggerDialog();
				}
			}
		}
	}
}