using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("_Level_1_Neighborhood");
    }

    public void Level2()
    {
        SceneManager.LoadScene("_Level_2_City");
    }

    public void Level3()
    {
        SceneManager.LoadScene("_Level_3_Country");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("_StartScreen");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("_Instructions");
    }

}
