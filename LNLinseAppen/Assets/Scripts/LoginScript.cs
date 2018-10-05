using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public InputField kundeIDV2;
    public InputField password;

    public Text IncorrectInfo;

    public void InputFromField()
    {
        if (kundeIDV2.text == "Arne" && password.text == "1234")
        {
            IncorrectInfo.text = "Velkommen " + kundeIDV2.text;
        }
        else
        {
            IncorrectInfo.text = "Forkert kundeID eller password";
        }
    }
    public void Start()
    {
        Application.targetFrameRate = 60;
    }

}
