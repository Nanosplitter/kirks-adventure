using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject PauseCanvas;
    private GameObject cameraObj;

    void Start()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1;

    }

    void Awake()
    {
        cameraObj = GameObject.Find("Main Camera");
    }
    public void PauseGame()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0; // Freezes time
        cameraObj.GetComponent<CameraController>().pauseMuted = true;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        cameraObj.GetComponent<CameraController>().pauseMuted = false;
    }

    public void Mute()
    {
        cameraObj.GetComponent<CameraController>().MuteToggle();
    }
}
