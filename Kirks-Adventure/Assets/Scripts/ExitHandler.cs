using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ExitHandler : MonoBehaviour
{
    // Fields set in the Unity Inspector pane
    public GameObject player;
    private bool isTripped = false;
    public Image youWin;

    private void Start()
    {
        youWin.enabled = false;
    }

    void Update()
    {
        

        if (Math.Abs(player.transform.position.x - this.transform.position.x) < 10 && isTripped == false)
        { 
            //LEVEL COMPLETE
            print("LEVEL COMPLETE");
            isTripped = true;
            youWin.enabled = true;
        }
    }
}