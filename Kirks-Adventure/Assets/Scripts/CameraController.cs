using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform kirk;
    private int enemiesAlive = 0;
    
    public AudioSource backgroundMusic;

    public AudioSource combatMusic;

    void EnemyDidSpawn() {
        enemiesAlive++;
    }

    void EnemyDidDie() {
        enemiesAlive--;
    }
    void FixedUpdate()
    {
        if (enemiesAlive > 0 && backgroundMusic.isPlaying) {
            backgroundMusic.Stop();
            combatMusic.Play();
        } else if (enemiesAlive == 0 && combatMusic.isPlaying) {
            combatMusic.Stop();
            backgroundMusic.Play();
        }
    }
}
