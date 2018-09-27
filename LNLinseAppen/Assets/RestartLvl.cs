using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartLvl : MonoBehaviour
{

    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Application.LoadLevel(scene.name); // Bruges ikke mere, men virker (Smiley)
            SceneManager.LoadScene(scene.name); //  Dynamisk - Henter den aktive scene fra scene, som er angivet i void Start
            SceneManager.LoadScene("LinseSorteringSpil"); // Går direkte ind på den scene man angiver - Ikke Dynamisk
        }
    }
}
