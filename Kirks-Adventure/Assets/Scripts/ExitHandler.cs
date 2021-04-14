using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitHandler : MonoBehaviour
{
    // Fields set in the Unity Inspector pane
    public GameObject player;
    private bool isTripped = false;
    public Image youWin;
    public int levelNumber;

    private void Start()
    {
        youWin.enabled = false;
        levelNumber = 1;
    }

    void Update()
    {
        

        if (Math.Abs(player.transform.position.x - this.transform.position.x) < 10 && isTripped == false)
        { 
            //LEVEL COMPLETE
            print("LEVEL COMPLETE");
            if(levelNumber == 1){
                SceneManager.LoadScene("_Level_2_City");
                levelNumber++;
            }
            else{
                isTripped = true;
                youWin.enabled = true;
            }
            
        }
    }
}
