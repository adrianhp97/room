using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveWindow1 : MonoBehaviour {

	public enum eInteractiveState
	{
		Active, //OPen
		Inactive, //CLose

	}

	private eInteractiveState m_state;

	void Start()
	{
		m_state = eInteractiveState.Inactive;
	}

	public void TrigegrInteraction()
	{
		if(!GetComponent<Animation>().isPlaying)
		{
			Debug.Log("Interactive window");
			switch (m_state) 
			{
			case eInteractiveState.Active:
				GetComponent<Animation>().Play("CloseWindow1");
				m_state = eInteractiveState.Inactive;
				break;
			case eInteractiveState.Inactive:
				GetComponent<Animation>().Play("OpenWindow1");
				m_state = eInteractiveState.Active;
				break;
			default:
				break;
			}
		}
	}
}
