using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPlayerPosition : MonoBehaviour
{
   

    Vector3 startPosition;

    void Awake()
    {
        startPosition = transform.position;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            gameObject.transform.position = startPosition;
        }
    }
}
