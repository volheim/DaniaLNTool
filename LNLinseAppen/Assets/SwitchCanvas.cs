using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCanvas : MonoBehaviour {

    [SerializeField]
    List<GameObject> canvases;
    [SerializeField]
    GameObject currentCanvas;


    public void AlarmCanvas()
    {
        SwitchToNewCanvas(canvases[0]);
    }

    public void UserPageCanvas()
    {
        SwitchToNewCanvas(canvases[1]);
    }

    void SwitchToNewCanvas(GameObject newCanvas)
    {
        currentCanvas.active = false;
        newCanvas.active = true;
        currentCanvas = newCanvas;
    }
}
