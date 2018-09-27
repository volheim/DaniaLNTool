using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    PointSystem ps;
    public void ChangeScene(string name)
    {
        ps = FindObjectOfType<PointSystem>();
        DestroyObject(GameObject.Find("CanvasCurrentScore"));
        DestroyObject(GameObject.Find("PointSystem"));

        SceneManager.LoadScene(name);
        if(name == "LinseSorteringSpil")
        {
            ps.point = 0;
            Text[] found = FindObjectsOfType<Text>();
            foreach (Text foundObj in found)
            {
                if (foundObj.name == "Point")
                {
                    ps.textpoint = foundObj;

                }
            }
            
        }
    }

}
