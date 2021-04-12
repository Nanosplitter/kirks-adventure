using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text instructions;

    void Start()
    {
        instructions.text = "Use A,D, or the left and right arrow keys to move";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("D"))
            instructions.text = "Look! An enemy vampire! Use your spells to attack him!";
        if (Input.GetKey(KeyCode.Mouse0))
            instructions.text = "Use the number line to change spells";
        if (Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Alpha3) || Input.GetKey(KeyCode.Alpha4))
            instructions.text = "Use the spacebar to jump over obstacles";
        if (Input.GetKey(KeyCode.Space))
            instructions.text = "Tutorial complete. Your journey begins now!";
    }
}
