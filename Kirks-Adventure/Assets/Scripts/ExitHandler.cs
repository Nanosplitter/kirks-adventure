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
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;

        if (Math.Abs(player.transform.position.x - this.transform.position.x) < 10 && isTripped == false)
        { 
            //LEVEL COMPLETE
            print("LEVEL COMPLETE");
            if(sceneName == "_Level_1_Neighborhood"){
                SceneManager.LoadScene("_Level_2_City");
            }
            else if(sceneName == "_Level_2_Cit"){
                SceneManager.LoadScene("_Level_3_Country");
                levelNumber++;
            }
            else if (sceneName == "_Level_3_Country") {
                isTripped = true;
                youWin.enabled = true;
            }
            
        }
    }
}
