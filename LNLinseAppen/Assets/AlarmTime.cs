using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlarmTime : MonoBehaviour {

    [SerializeField]
    internal int morgenTime, morgenMinut, aftenTime, aftenMinut;


    [SerializeField]
    List<GameObject> textFields;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void MorgenTimeOp() { morgenTime++; if (morgenTime >= 24) { morgenTime = 0; } UpdateTimes(); }
    public void MorgenTimeNed() { morgenTime--; if (morgenTime <= -1) { morgenTime = 23; } UpdateTimes(); }
    public void MorgenMinutOp() { morgenMinut++; if (morgenMinut >= 60) { morgenMinut = 0; } UpdateTimes(); }
    public void MorgenMinutNed() { morgenMinut--; if (morgenMinut <= -1) { morgenMinut = 59; } UpdateTimes(); }

    public void AftenTimeOp() { aftenTime++; if (aftenTime >= 24) { aftenTime = 0; } UpdateTimes(); }
    public void AftenTimeNed() { aftenTime--; if (aftenTime <= -1) { aftenTime = 23; } UpdateTimes(); }
    public void AftenMinutOp() { aftenMinut++; if (aftenMinut >= 60) { aftenMinut = 0; } UpdateTimes(); }
    public void AftenMinutNed() { aftenMinut--; if (aftenMinut <= -1) { aftenMinut = 59; } UpdateTimes(); }

    public void UpdateTimes()
    {
        int i = 0;
        foreach (GameObject go in textFields)
        {
            if(i == 0)
            {
                go.GetComponent<InputField>().text = morgenTime.ToString();
                
                i++;
            }
            else if(i == 1)
            {
                go.GetComponent<InputField>().text = morgenMinut.ToString();
                i++;
            }
            else if (i == 2)
            {
                go.GetComponent<InputField>().text = aftenTime.ToString();
                i++;
            }
            else
            {
                go.GetComponent<InputField>().text = aftenMinut.ToString();
            }
        }
    }
}
