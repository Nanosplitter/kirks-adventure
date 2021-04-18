using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathTime : MonoBehaviour
{
    public Text Death;

    void Start()
    {
        Death.text = Timer.timeOfDeath;
    }
    
}
