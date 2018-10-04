using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSelectedDayInfo : MonoBehaviour
{
    List<DateTime> dateTime = new List<DateTime>();
    string text = "Info";
    public Text giveText;
    [SerializeField]
    GameObject cal;
    DateTime thisDate1;
    
    //public GameObject selectedButton;
    public Button button;

    [SerializeField]
    InputField textBox;

    // Use this for initialization
    void Start()
    {
        thisDate1 = new DateTime(2018, 4, 10);
    }

    public void SetEvent()
    {
        cal.GetComponent<Calendar>().AddEvent(Convert.ToInt16(button.gameObject.name.Remove(0,4)), textBox.text, null, false);
        giveText.text = textBox.transform.GetChild(2).GetComponent<Text>().text;
    }
}
