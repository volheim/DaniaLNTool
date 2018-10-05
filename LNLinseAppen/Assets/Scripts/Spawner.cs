using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabSphere; //, prefabCube;

    [SerializeField]
    private float interval, maxInterval = 3, totalRunTime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalRunTime += Time.deltaTime;
        interval += Time.deltaTime;
        if (interval > maxInterval)
        {
          //  Instantiate(prefabCube, new Vector3(Random.Range(-4.41f, 4.41f), 16, 0), Quaternion.identity);
            Instantiate(prefabSphere, new Vector3(Random.Range(-4.41f, 4.41f), 10, 0), Quaternion.identity);
            interval = 0;
        }

        if (totalRunTime > 6 )
        {
            maxInterval = 2;
        }

        if (totalRunTime > 12)
        {
            maxInterval = 1;
        }
    }
}
