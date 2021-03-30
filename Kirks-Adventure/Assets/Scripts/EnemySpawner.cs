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


    public GameObject[] enemyInstances;

    void Awake()
    {
        enemyInstances = new GameObject[numEnemies];
        GameObject anchor = GameObject.Find("EnemySpawner");
        GameObject enemy;

        for (int i = 0; i < numEnemies; i++)
        {
            int prefabNum = Random.Range(0, enemyPrefabs.Length);

            enemy = Instantiate(enemyPrefabs[prefabNum]) as GameObject;

            Vector3 enemyPos = Vector3.zero;
            enemyPos.x = player.transform.position.x + 15;
            enemyPos.y = -1;

            enemy.transform.parent = anchor.transform;

            enemyInstances[i] = enemy;
        }
    }
    void Update()
    {
        // Iterate over each cloud that was created
        foreach (GameObject enemy in enemyInstances)
        {
            if (player.transform.position.x >= 5)
            {
                print("player transform position x >= 5!!!");
            }

        }
    }
}
