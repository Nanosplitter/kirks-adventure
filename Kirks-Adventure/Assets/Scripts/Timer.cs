using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text TimerText;
    public Image healthBarImage;

    private float startTime;
    private float endTime;
    public static string timeOfDeath;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        if ((t % 60) < 10)
        {
            TimerText.text = minutes + ":0" + seconds;
        } else {
            TimerText.text = minutes + ":" + seconds;
        }

        if (healthBarImage.fillAmount <= 0)
        {
            endTime = Time.time;
            if ((t % 60) < 10)
            {
                timeOfDeath = minutes + ":0" + seconds;
            }
            else
            {
                timeOfDeath = minutes + ":" + seconds;
            }
            //TimerText.text = "";
        }
    }
}
