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
    public GameObject spellHandler;
   
    void Start()
    {
        fire.text = "Fire";
        water.text = "";
        earth.text = "";
        air.text = "";
        spellHandler.GetComponent<Spell>().SetSpell("fire");
    }

    void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            fire.text = "Fire";
            water.text = "";
            earth.text = "";
            air.text = "";
            spellHandler.GetComponent<Spell>().SetSpell("fire");
        }
        else if (Input.GetKeyUp("2"))
        {
            fire.text = "";
            water.text = "Water";
            earth.text = "";
            air.text = "";
            spellHandler.GetComponent<Spell>().SetSpell("water");
        }
        else if (Input.GetKeyUp("3"))
        {
            fire.text = "";
            water.text = "";
            earth.text = "Earth";
            air.text = "";
            spellHandler.GetComponent<Spell>().SetSpell("earth");
        }
        else if (Input.GetKeyUp("4"))
        {
            fire.text = "";
            water.text = "";
            earth.text = "";
            air.text = "Air";
            spellHandler.GetComponent<Spell>().SetSpell("air");
        }
    }
}
