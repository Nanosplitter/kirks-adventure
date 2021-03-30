using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Fields set in the Unity Inspector pane
    public GameObject player;
    public int numEnemies = 40; 
    public GameObject[] enemyPrefabs;  
    public Vector3 enemyPosMin; // relative to player
    public Vector3 enemyPosMax; // relative to player

    private bool isTripped = false;

    public GameObject[] enemyInstances;

    void Update()
    {
        enemyInstances = new GameObject[numEnemies];
        GameObject anchor = GameObject.Find("EnemySpawner");
        GameObject enemy;

        if (player.transform.position.x >= -5 && isTripped == false)
        { 
            for (int i = 0; i < numEnemies; i++)
            {
                int prefabNum = Random.Range(0, enemyPrefabs.Length);

                enemy = Instantiate(enemyPrefabs[prefabNum]) as GameObject;

                Vector3 enemyPos = new Vector3(player.transform.position.x + 15, player.transform.position.y, 0f);

                enemy.transform.parent = anchor.transform;

                enemyInstances[i] = enemy;

                print("Spawning Enemy!!!");
            }
            isTripped = true;
        }
    }
}
