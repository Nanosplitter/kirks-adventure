using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Enemy;

    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward;
    }
}
