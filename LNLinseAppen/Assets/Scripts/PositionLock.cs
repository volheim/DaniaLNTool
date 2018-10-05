using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLock : MonoBehaviour
{

    [SerializeField]
    GameObject locker;

    float timer;
    bool locked;

    // Use this for initialization
    public void DateTextSeparator()
    {
        gameObject.name = gameObject.name + gameObject.transform.parent.name;
        transform.parent = GameObject.Find("Canvas").transform;
        transform.position = locker.transform.position;
        gameObject.active = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > 0.5f && !locked)
        {
            DateTextSeparator();
            locked = true;
        }
    }

    public void SetActive()
    {
        gameObject.active = true;
    }

}
