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
        print("EnemyDidSpawn Called");
        enemiesAlive++;
    }

    public void EnemyDidDie() {
        print("EnemyDidDie Called");
        enemiesAlive--;
    }

    public void MuteToggle()
    {
        muted = !muted;
        
    }
    void Update()
    {  
        // print(enemiesAlive);
        if (muted) {
            backgroundMusic.Stop();
            combatMusic.Stop();
            return;
        }

        if (enemiesAlive > 0 && backgroundMusic.isPlaying) {
            print("Playing combat music");
            backgroundMusic.Stop();
            combatMusic.Play();
        } else if (enemiesAlive <= 0 && combatMusic.isPlaying) {
            print("Playing background music");
            combatMusic.Stop();
            backgroundMusic.Play();
        } else if (!combatMusic.isPlaying && !backgroundMusic.isPlaying) {
            backgroundMusic.Play();
        }
    }
}
