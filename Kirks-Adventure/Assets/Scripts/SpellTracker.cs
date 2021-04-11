using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(this.transform.position.y);
        if (this.transform.position.y < -20) {
            Destroy(gameObject);
        }
    }
}
