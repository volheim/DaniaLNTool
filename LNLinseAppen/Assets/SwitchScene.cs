﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
