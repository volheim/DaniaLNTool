using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinseSorteringMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(Input.mousePosition.x / 80,0,0);
	}
}
