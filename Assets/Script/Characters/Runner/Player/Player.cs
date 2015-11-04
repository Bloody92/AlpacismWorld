using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 6.0F;

    public float jumpDistance;
    public float jumpCounting;
    private float maxHealth;
    public float health;
    private float frameCounter;
    private bool jumping;

    private Rigidbody2D controller;

    public Player()
    {

    }

    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
        jumping = false;
        frameCounter = 0;
        maxHealth = 50.0f;
        health = maxHealth;

    }


    void Update()
    {
        //Health controller

        //Controllers of movement
        if ((Input.GetKeyDown(KeyCode.Space)) && (jumping == false))
        {
            controller.AddForce(new Vector2(0, jumpDistance), ForceMode2D.Impulse);
            
            jumping = true;
        }

        if (jumping == true)
        {
            frameCounter++;

            if (frameCounter >= jumpCounting)
            {
                jumping = false;
                frameCounter = 0;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        
    }

    void AddDamage()
    {
        if (health > 0)
        {
            health -= 10.0f;
        }
    }

    public float SetHealth()
    {

        return health;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("pato");
        //if collides with player Die
        if (other.tag == "Obstacle")
        { 
            Debug.Log("pato");
            AddDamage();
        }

    }
}
