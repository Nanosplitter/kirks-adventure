using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float maxHealth, health;
    public HealthBar healthBar;
    public int goal;


    public void TakeDamage()
    {
        health -= Mathf.Min(Random.value, health / 4f);
        healthBar.UpdateHealthBar();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            TakeDamage();
        }
    }

    public void OnDestroy()
    {
        goal++;
    }

}
