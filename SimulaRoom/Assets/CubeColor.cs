using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour {

    public Color ObjectColor;
    private Material materialColored;

    // Use this for initialization
    void Start () {
        Debug.Log("I am alive!");
        //this.GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1); //C#
        materialColored = new Material(Shader.Find("Diffuse"));
        materialColored.color = ObjectColor;
        this.GetComponent<Renderer>().material = materialColored;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
