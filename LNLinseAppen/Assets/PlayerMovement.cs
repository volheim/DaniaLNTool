﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

     Vector3 startPosition;

    void Awake()
    {
        startPosition = transform.position;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.left * speed) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate((Vector2.right * speed) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = startPosition;
        }

    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Wall")
        {
            transform.position = startPosition;
        }
    }


}
