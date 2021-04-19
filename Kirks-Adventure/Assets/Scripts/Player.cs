using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float maxHealth = 100; 
    public float health = 100;
    public HealthBar healthBar;
    public AudioSource ouch;

    public void TakeDamage()
    {
        health -= Random.value * 10;
        ouch.Play();
        healthBar.UpdateHealthBar();
    }

    public void HealDamage()
    {
        health += 40;
        healthBar.UpdateHealthBar();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            TakeDamage();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Spell_Enemy"))
        {
            Destroy(other.gameObject);
            TakeDamage();
        }

        if (other.gameObject.CompareTag("Health_Potion"))
        {
            Destroy(other.gameObject);
            HealDamage();
        }
    }

}
