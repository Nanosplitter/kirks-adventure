using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDespawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollision(Collision collision)
    {
        print("COLLISION");
        Destroy(this);
    }
}
