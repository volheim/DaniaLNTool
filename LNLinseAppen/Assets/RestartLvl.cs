﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Scene management - sørger for at scene skift virker


public class RestartLvl : MonoBehaviour
{

    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene(); //Tager den aktive scene, man arbejder i
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            //Application.LoadLevel(scene.name); // Bruges ikke mere, men virker (Smiley)
            //SceneManager.LoadScene(scene.name); //  Dynamisk - Henter den aktive scene fra scene, som er angivet i void Start
            Debug.Log("Let me not switch scene, u sunava bits");
            SceneManager.LoadScene("LinseSorteringSpil"); // Går direkte ind på den scene man angiver - Ikke Dynamisk
        }
    }
}