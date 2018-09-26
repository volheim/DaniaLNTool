using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinseSorteringLinseStyrke : MonoBehaviour
{

    [SerializeField]
    internal int styrke;

    [SerializeField]
    bool linse;

    [SerializeField]
    List<Color> colors;

    // FallDown fd;

    // Use this for initialization
    void Start()
    {
        colors.Add(Color.black);
        colors.Add(Color.blue);
        colors.Add(Color.yellow);
        colors.Add(Color.gray);
        colors.Add(Color.red);
        if (linse)
        {
          //  fd = GetComponent<FallDown>();
            styrke = Random.Range(-2, 3);
           // gameObject.GetComponent<MeshRenderer>().materials[0] = fd.colors[styrke + 2];

        }
        gameObject.GetComponent<MeshRenderer>().material.color = colors[styrke + 2];
    }

}
