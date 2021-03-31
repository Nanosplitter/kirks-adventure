using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    CharacterController characterController;
    public GameObject player;
    public float speed = 1.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 50.0f;
    private int timeSettled = 50;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.GetComponent<Rigidbody>().velocity.y == 0 && timeSettled > 0) {
            timeSettled--;
        }

        if (timeSettled == 0) {
            if (Math.Abs(player.transform.position.x - this.transform.position.x) < 5) {
                moveDirection = new Vector3(0.0f, 0.0f, 0.0f);
            }else if (player.transform.position.x > this.transform.position.x) {
                moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
            } else {
                moveDirection = new Vector3(-1.0f, 0.0f, 0.0f);
            }
            
            moveDirection *= speed;
            moveDirection.y -= gravity * Time.deltaTime;
            characterController.Move(moveDirection * Time.deltaTime);
        }
        

        // moveDirection.y -= gravity * Time.deltaTime;

        
    }
}
