using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeFormater : MonoBehaviour
{
    public Conductor conductor;
    public float songPosition;

    public TextMeshProUGUI textElement;
    public string textValue;

    // Start is called before the first frame update
    void Start()
    {
        conductor = GameObject.Find("/Audio").GetComponent<Conductor>();

        //totSeconds = 


    }

    // Update is called once per frame
    void Update()
    {
        songPosition += Time.deltaTime;

        int hours = Mathf.FloorToInt(songPosition / 3600F);
        int minutes = Mathf.FloorToInt((songPosition % 3600) / 60);
        int seconds = Mathf.FloorToInt(songPosition % 60);

        string formattedTime = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

        textValue = formattedTime;
        textElement.text = textValue;

    }


}
