using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabCube, prefabSphere;

    [SerializeField]
    private float interval;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        interval += Time.deltaTime;
        if (interval > 3)
        {
            Instantiate(prefabCube, new Vector3(Random.Range(-4.41f, 4.41f), 16, 0), Quaternion.identity);
            Instantiate(prefabSphere, new Vector3(Random.Range(-4.41f, 4.41f), 10, 0), Quaternion.identity);
            interval = 0;
        }
    }
}
