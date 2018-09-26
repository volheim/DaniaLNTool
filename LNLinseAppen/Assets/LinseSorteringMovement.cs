using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinseSorteringMovement : MonoBehaviour {

    Vector3 move;

    [SerializeField]
    float speed;
    [SerializeField]
    int screenWidth;

	// Use this for initialization
	void Start () {
        screenWidth = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {

        move = Input.GetTouch(0).deltaPosition;

        transform.Translate(new Vector3(move.x,0,0)/screenWidth*speed);
        if (transform.position.x > 7.9f)
        {
            transform.position = new Vector3(7.9f,0,0);
        }
        if (transform.position.x < -7.9f)
        {
            transform.position = new Vector3(-7.9f, 0, 0);
        }

    }
}
