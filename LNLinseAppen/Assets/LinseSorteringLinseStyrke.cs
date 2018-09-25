using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinseSorteringLinseStyrke : MonoBehaviour
{

    [SerializeField]
    internal int styrke;

    [SerializeField]
    bool linse;


    FallDown fd;

    // Use this for initialization
    void Start()
    {

        if (linse)
        {
            fd = GetComponent<FallDown>();
            styrke = Random.Range(-2, 3);
            gameObject.GetComponent<MeshRenderer>().materials[0] = fd.colors[styrke + 2];
        }


    }

}
