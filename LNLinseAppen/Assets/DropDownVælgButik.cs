using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownVælgButik : MonoBehaviour
{

    Dropdown dropDown;
    [SerializeField]
    private Text dropTextTelefon, dropTextAdresse, dropTextEmail;
    private int dropDownIndex;
    private Text dropDownMessage;

    // Use this for initialization
    void Start()
    {
        dropDown = GetComponent<Dropdown>();
        //Debug.Log("Starting Dropdown Value : " + dropDown.value);
    }

    // Update is called once per frame
    void Update()
    {
        dropDownIndex = dropDown.value;

        if (dropDownIndex == 0)
        {
            dropTextTelefon.text = "";
            dropTextAdresse.text = "";
            dropTextEmail.text = "";
        }

        //Debug.Log("DropdownIndex" + dropDownIndex);
        if (dropDownIndex == 1)
        {
            dropTextTelefon.text = "Telefon : 96 32 52 30";
            dropTextAdresse.text = "Søndergade 4, 8500 Grenå";
            dropTextEmail.text = "info@louisnielsen.dk";
            //Debug.Log("Im in the if statement");
        }

        if (dropDownIndex == 2)
        {
            dropTextTelefon.text = "Telefon : 96 32 50 72";
            dropTextAdresse.text = "Østervold 15 8900 Randers";
            dropTextEmail.text = "info@louisnielsen.dk";
            //Debug.Log("Im in the if statement");
        }

        if (dropDownIndex == 3)
        {
            dropTextTelefon.text = "Telefon : 96 32 52 06";
            dropTextAdresse.text = "Kongensgade 26, 5000 Odense";
            dropTextEmail.text = "info@louisnielsen.dk";
            //Debug.Log("Im in the if statement");
        }






    }
}
