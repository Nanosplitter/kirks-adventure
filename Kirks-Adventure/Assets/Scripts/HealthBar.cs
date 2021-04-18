using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public Player player;
    public static int fill;

    public void UpdateHealthBar()
    {
        
        healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
        if (healthBarImage.fillAmount <= 0) {
            SceneManager.LoadScene("_DeathScreen");
            fill = 0;
            
        }
    }

}