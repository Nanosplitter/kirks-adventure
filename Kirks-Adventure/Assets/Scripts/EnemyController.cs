using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    CharacterController characterController;
    public GameObject player;
    public Image enemyHealth;

    public Animator animator;

    public float speed = 1.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 50.0f;
    private int timeSettled = 50;
    public GameObject prefabProjectile;
    private GameObject projectile;
    private Vector3 moveDirection = Vector3.zero;
    public string type;
    private string weak;
    private string strong;
    private GameObject cameraObj;
    public float health = 100;
    public float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        player = GameObject.Find("Player");
        InvokeRepeating("ShootSpell", 1f, 1f);
    }

    void Awake()
    {
        print("AHHHHHHHHHHHHH");
        if (type.Equals("fire")) {
            strong = "Fire(Clone)";
            weak = "Water(Clone)";
        } else if (type.Equals("water")) {
            strong = "Water(Clone)";
            weak = "Earth(Clone)";
        } else if (type.Equals("air")) {
            strong = "Air(Clone)";
            weak = "Fire(Clone)";
        } else if (type.Equals("earth")) {
            strong = "Earth(Clone)";
            weak = "Water(Clone)";
        }
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

        if (player.transform.position.x > this.transform.position.x)
        {
            animator.SetFloat("EnemyHorizontal", 1);
        } else
        {
            animator.SetFloat("EnemyHorizontal", -1);
        }


        // moveDirection.y -= gravity * Time.deltaTime;


    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Spell"))
        {
            print(health);
            if (health > 0) {
                string spellName = other.gameObject.name;
                print(spellName);
                if (spellName.Equals(strong)) {
                    health -= 5;
                    enemyHealth.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1f);
                } else if (spellName.Equals(weak)) {
                    health -= 34;
                    enemyHealth.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1f);
                } else {
                    health -= 15;
                    enemyHealth.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1f);
                }
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
