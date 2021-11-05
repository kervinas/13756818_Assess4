using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private static TimeManager instance;
    public Text time;
    private float timer;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float totalTime = Time.time - timer;
        string minutes = ((int)totalTime / 60).ToString();
        string seconds = (totalTime % 60).ToString("f2");
        time.text = "Time: " + minutes + ":" + seconds;
    }
}
