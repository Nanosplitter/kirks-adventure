using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ExitHandler : MonoBehaviour
{
    // Fields set in the Unity Inspector pane
    public GameObject player;
    private bool isTripped = false;

    void Update()
    {
        

        if (Math.Abs(player.transform.position.x - this.transform.position.x) < 10 && isTripped == false)
        { 
            //LEVEL COMPLETE
            print("LEVEL COMPLETE");
            isTripped = true;
        }
    }
}
