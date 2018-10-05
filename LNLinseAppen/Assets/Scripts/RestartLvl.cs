using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Scene management - sørger for at scene skift virker


public class RestartLvl : MonoBehaviour
{

    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene(); //Tager den aktive scene, man arbejder i - Den scene scriptet er sat på.
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            //Application.LoadLevel(scene.name); // Virker, men scenemanager er foretrukken
            //SceneManager.LoadScene(scene.name); //  Dynamisk - Henter den aktive scene fra scene, som er angivet i void Start
            Debug.Log("Let me switch scene, u sunava bits");
            SceneManager.LoadScene("LinseSorteringSpil"); // Går direkte ind på den scene man angiver - Ikke Dynamisk
        }
    }
}
