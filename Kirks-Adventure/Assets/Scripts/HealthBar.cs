using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public Player player;
    public Image dead;

    public void Start()
    {
        dead.enabled = false;
    }

    public void UpdateHealthBar()
    {
        
        healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
        if (healthBarImage.fillAmount <= 0) dead.enabled = true;
    }

}