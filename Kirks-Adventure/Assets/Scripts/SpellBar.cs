using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBar : MonoBehaviour
{
    public Text fire;
    public Text water;
    public Text earth;
    public Text air;
    public string currSpell;
   
    /*void selectSpell(string currSpell)
    {
        if (currSpell == "Fire")
        {
            fire.enabled = true;
            water.enabled = false;
            earth.enabled = false;
            air.enabled = false;
        }

        else if (currSpell == "Water")
        {
            fire.enabled = false;
            water.enabled = true;
            earth.enabled = false;
            air.enabled = false;
        }

        else if (currSpell == "Earth")
        {
            fire.enabled = false;
            water.enabled = false;
            earth.enabled = true;
            air.enabled = false;
        }

        else if (currSpell == "Air")
        {
            fire.enabled = false;
            water.enabled = false;
            earth.enabled = false;
            air.enabled = true;
        }
    }*/

    void Start()
    {
        fire.text = "Fire";
        water.text = "";
        earth.text = "";
        air.text = "";
        currSpell = "Fire";
    }

    void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            fire.text = "Fire";
            water.text = "";
            earth.text = "";
            air.text = "";
            currSpell = "Fire";
        }
        else if (Input.GetKeyUp("2"))
        {
            fire.text = "";
            water.text = "Water";
            earth.text = "";
            air.text = "";
            currSpell = "Water";
        }
        else if (Input.GetKeyUp("3"))
        {
            fire.text = "";
            water.text = "";
            earth.text = "Earth";
            air.text = "";
            currSpell = "Earth";
        }
        else if (Input.GetKeyUp("4"))
        {
            fire.text = "";
            water.text = "";
            earth.text = "";
            air.text = "Air";
            currSpell = "Air";
        }
    }
}
