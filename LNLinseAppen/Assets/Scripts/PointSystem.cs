using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{

    [SerializeField]
    public Text textpoint;

    private static bool created;

    [SerializeField]
    public int point;


    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePoint();

    }
    void UpdatePoint()
    {
        textpoint.text = "Score: " + point.ToString();
    }
    public void AddPoint()
    {
        point += 1;
    }
}
