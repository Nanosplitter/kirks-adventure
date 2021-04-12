using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public GameObject kirk;

    public GameObject firePrefab;
    public GameObject waterPrefab;
    public GameObject earthPrefab;
    public GameObject airPrefab;
    private GameObject prefabProjectile;
    private GameObject projectile;
    public float velocityMult = 4f;
    private bool isClicking = false;
    private int kirkMovingRight = 1;

    void setSpell(string type)
    {
        switch (type) {
            case "water":
                prefabProjectile = waterPrefab;
                break;
            case "air":
                prefabProjectile = airPrefab;
                break;
            case "earth":
                prefabProjectile = earthPrefab;
                break;
            case "fire":
                prefabProjectile = firePrefab;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // print(Input.GetAxis("Horizontal"));
        if (Input.GetAxis("Horizontal") > 0) {
            kirkMovingRight = 1;
        } else if (Input.GetAxis("Horizontal") < 0) {
            kirkMovingRight = -1;
        }

        if (Input.GetMouseButtonDown(0) && !isClicking) {
            projectile = Instantiate(prefabProjectile) as GameObject;
            // Start it at the launchPoint
            projectile.transform.position = kirk.transform.position;// + new Vector3(0.0f, 1f, 0.0f);
            // projectile.GetComponent<Rigidbody>().isKinematic = true;
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(40 * kirkMovingRight, 0.0f, 0.0f);
        }

        if (Input.GetMouseButtonUp(0)) {
            isClicking = false;
        }
    }
}
