using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitHandler : MonoBehaviour
{
    public GameObject player;
    private bool isTripped = false;

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        isTripped = false;

        if (Math.Abs(player.transform.position.x - this.transform.position.x) < 10 && isTripped == false)
        { 
            print("LEVEL COMPLETE");

            switch(sceneName) {
                case "_Level_1_Neighborhood":
                    SceneManager.LoadScene("Level1_Complete");
                    break;

                case "_Level_2_City":
                    SceneManager.LoadScene("Level2_Complete");
                    break;

                case "_Level_3_Country":
                    isTripped = true;
                    SceneManager.LoadScene("_WinScreen");
                    break;

                case "Level1_Complete":
                    if (Input.GetKeyDown(KeyCode.N))
                    {
                        SceneManager.LoadScene("_Level_2_City");
                    }
                    break;

                case "Level2_Complete":
                    if (Input.GetKeyDown(KeyCode.N))
                    {
                        SceneManager.LoadScene("_Level_3_Country");
                    }
                    break;
            }
        }
    }
}
