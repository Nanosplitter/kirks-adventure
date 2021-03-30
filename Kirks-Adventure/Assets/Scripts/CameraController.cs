using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform kirk;

    void FixedUpdate()
    {
        this.transform.position = new Vector3(kirk.transform.position.x, kirk.transform.position.y + 3, this.transform.position.z);
    }
}
