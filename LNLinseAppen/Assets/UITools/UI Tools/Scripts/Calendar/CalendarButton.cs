using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Calendar UI Tool - Data Class
/// Placed on each button of a Calendar.
/// 
/// Developed by Dibbie.
/// Website: http://www.simpleminded.x10host.com
/// Email: mailto:strongstrenth@hotmail.com
/// Discord Server: https://discord.gg/33PFeMv
/// </summary>

public class CalendarButton : MonoBehaviour, IPointerClickHandler {

    protected Calendar calendar;
    protected ButtonEventData data;

    public GameObject calendarHandler;

    void Start()
    {
        calendarHandler = GameObject.Find("Calendar Handler");
    }

    public void SetCalendar(Calendar targetCalendar, ButtonEventData eventData)
    {
        calendar = targetCalendar;
        data = eventData;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        calendarHandler.GetComponent<ShowSelectedDayInfo>().button = gameObject.GetComponent<Button>();
        calendar.SendClickEvents(eventData, data);

        
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("DatoTag"))
        {
            item.SetActive(false);
        }

        GameObject.Find("Canvas").transform.FindChild("Dato Text" + gameObject.name).gameObject.SetActive(true);

        calendarHandler.GetComponent<ShowSelectedDayInfo>().giveText = GameObject.Find("Canvas").transform.FindChild("Dato Text" + gameObject.name).GetComponent<Text>();
    }
}
