using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneSong : MonoBehaviour
{
    public AudioSource backgroundMusic;

    void Awake()
    {
    
        backgroundMusic.Play();

    }
}
