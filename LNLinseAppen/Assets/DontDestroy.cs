using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroy : MonoBehaviour
{



    private static bool created;

    private void Start()
    {
        created = false;
    }

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);

            //if (SceneManager.sceneLoaded("GameOver") == true)
        }
    }

    private void Update()
    {

        if (Application.loadedLevelName == "GameOver")
        {
            Vector3 movement = new Vector3(50, -272, 0);
            transform.position = movement;
            Debug.Log(movement);
        }
    }
}
