using UnityEngine;
using System.Collections;

public class LifeControl : Player {

    Player life;
    private float actualHealth;

    public Material health6;
    public Material health5;
    public Material health4;
    public Material health3;
    public Material health2;
    public Material health1;
    
    // Use this for initialization
    void Start ()
    {
        actualHealth = health;
       // actualHealth = life.SetHealth();
    }

    // Update is called once per frame
    void Update ()
    {

        //actualHealth = life.SetHealth();

        if (health == 50)
        {
            GetComponent<Renderer>().material = health6;
        }
        else if (health == 40)
        {
            GetComponent<Renderer>().material = health5;
        }
        else if (actualHealth == 30)
        {
            GetComponent<Renderer>().material = health4;
        }
        else if (actualHealth == 20)
        {
            GetComponent<Renderer>().material = health3;
        }
        else if (actualHealth == 10)
        {
            GetComponent<Renderer>().material = health2;
        }
        else if (actualHealth == 0)
        {
            GetComponent<Renderer>().material = health1;
        }
    }
}
