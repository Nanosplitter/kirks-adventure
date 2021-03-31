using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float maxHealth = 100; 
    public float health = 100;
    public HealthBar healthBar;
    public int goal;


    public void TakeDamage()
    {
        health -= Mathf.Min(Random.value * 10, health / 4f);
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

    void OnTriggerEnter(Collider other)
    {
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Spell_Enemy"))
        {
            other.gameObject.SetActive(false);
            TakeDamage();
        }
    }

}
