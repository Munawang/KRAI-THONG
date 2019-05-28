using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Time_Lv1 : MonoBehaviour
{
    public static float timeStart = 90;
    public Text textBox;

    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    void Update() {
        if (HealthBarBoss.health == 0)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(90);
            stopWatch.Stop();
        }
        else {
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }
}
