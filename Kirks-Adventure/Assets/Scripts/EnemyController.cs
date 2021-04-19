using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    CharacterController characterController;
    public GameObject player;
    public GameObject enemy;

    public Animator animator;

    public float speed = 1.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 50.0f;
    private int timeSettled = 50;
    public GameObject prefabProjectile;
    private GameObject projectile;
    private Vector3 moveDirection = Vector3.zero;

    public GameObject cameraObj;

    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        player = GameObject.Find("Player");
        enemy.transform.position = new Vector3(0, 0.0f, 0);
        InvokeRepeating("ShootSpell", 1f, 1f);
    }

    void Awake()
    {
        print("AHHHHHHHHHHHHH");
        
        cameraObj = GameObject.Find("Main Camera");
        print(cameraObj);
        cameraObj.GetComponent<CameraController>().EnemyDidSpawn();
    }

    // Update is called once per frame
    void Update()
    {

        if (this.GetComponent<Rigidbody>().velocity.y == 0 && timeSettled > 0) {
            timeSettled--;
        }

        if (timeSettled == 0) {
            if (Math.Abs(player.transform.position.x - this.transform.position.x) < 5) {
                moveDirection = new Vector3(0.0f, 0.0f, 0.0f);
            } else if (player.transform.position.x > this.transform.position.x) {
                moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
            } else {
                moveDirection = new Vector3(-1.0f, 0.0f, 0.0f);
            }
            
            moveDirection *= speed;
            moveDirection.y -= gravity * Time.deltaTime;
            characterController.Move(moveDirection * Time.deltaTime);
            
        }

        if (Math.Abs(player.transform.position.x) < this.transform.position.x)
        {
            animator.SetFloat("EnemyHorizontal", -1.0f);
        } else
        {
            animator.SetFloat("EnemyHorizontal", 1.0f);
        }


        // moveDirection.y -= gravity * Time.deltaTime;


    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Spell"))
        {
            if (health != 0) {
                health--;
            } else {
                
                Destroy(this.gameObject);
                cameraObj.GetComponent<CameraController>().EnemyDidDie();
            }
            Destroy(other.gameObject);
            
        }
    }

    void ShootSpell() {
        projectile = Instantiate(prefabProjectile) as GameObject;
        // Start it at the launchPoint
        projectile.transform.position = this.transform.position;// + new Vector3(0.0f, 1f, 0.0f);
        // projectile.GetComponent<Rigidbody>().isKinematic = true;
        if (player.transform.position.x > this.transform.position.x) {
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(40, 0.0f, 0.0f);
        } else {
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(-40, 0.0f, 0.0f);
        }
        
    }
}
