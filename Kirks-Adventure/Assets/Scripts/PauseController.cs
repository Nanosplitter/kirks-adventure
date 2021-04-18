using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject PauseCanvas;

    void Start()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1;

    }

    public void PauseGame()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0; // Freezes time
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
    }
}
