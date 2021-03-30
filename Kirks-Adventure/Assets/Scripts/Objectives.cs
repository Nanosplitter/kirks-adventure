using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{
    public Player player;
    public Text objective;
    public int goal = 1;

    void OnGUI()
    {
        DrawHUD();
    }

    void Update()
    {
        if (IsAchieved())
        {
            Complete();
            //Destroy(goal);
        }
    }

    public bool IsAchieved()
    {
        return (player.goal >= goal);
    }

    public void Complete()
    {
        objective.text = "";
    }

    public void DrawHUD()
    {
        objective.text = "Slay your bretheren and flee your homeland";
    }
}


