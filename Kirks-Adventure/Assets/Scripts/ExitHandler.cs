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
    public Image level1Pic;
    public Image level2Pic;

    private void Start()
    {
        youWin.enabled = false;
        level1Pic.enabled = false;
        level2Pic.enabled = false;
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        isTripped = false;

        if (Math.Abs(player.transform.position.x - this.transform.position.x) < 10 && isTripped == false)
        { 
            // if ( Input.GetKeyDown(KeyCode.LeftControl) == true )
            //LEVEL COMPLETE
            print("LEVEL COMPLETE");
            if(sceneName == "_Level_1_Neighborhood"){
                level1Pic.enabled = true;
                SceneManager.LoadScene("_Level_2_City");
            }
            else if(sceneName == "_Level_2_City"){
                SceneManager.LoadScene("_Level_3_Country");
            }
            else if (sceneName == "_Level_3_Country") {
                isTripped = true;
                youWin.enabled = true;
            }
            
        }
    }
}
