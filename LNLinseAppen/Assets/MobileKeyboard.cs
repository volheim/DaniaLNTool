using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileKeyboard : MonoBehaviour {

	public void Activate()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
}
