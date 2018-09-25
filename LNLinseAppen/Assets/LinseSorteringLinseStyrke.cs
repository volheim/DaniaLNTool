using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinseSorteringLinseStyrke : MonoBehaviour {

    [SerializeField]
    int styrke;

    [SerializeField]
    bool linse;
	// Use this for initialization
	void Start () {
        if (linse)
        {
            styrke = Random.Range(-2, 3);
        }
	}

}
