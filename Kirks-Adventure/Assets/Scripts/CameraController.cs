using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform kirk;
    private int enemiesAlive = 0;
    
    public AudioSource backgroundMusic;

    public AudioSource combatMusic;

    public bool muted = false;

    public void EnemyDidSpawn() {
        StartCombat();
    }

    public void EnemyDidDie() {
        StartBackground();
    }

    public void MuteToggle()
    {
        muted = !muted;
        
    }

    public void StartCombat() {
        if (!muted) {
            backgroundMusic.Stop();
            combatMusic.Play();
        }
    }

    public void StartBackground() {
        if (!muted) {
            combatMusic.Stop();
            backgroundMusic.Play();
        }
    }

    void Update()
    {  
        // print(enemiesAlive);
        if (muted) {
            backgroundMusic.Stop();
            combatMusic.Stop();
            return;
        }

        
        if (!combatMusic.isPlaying && !backgroundMusic.isPlaying) {
            backgroundMusic.Play();
        }
    }
}
