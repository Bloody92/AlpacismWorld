using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Enemy enemy;
    public GameObject fumeExplosion;
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Translate obstacles and decoration to left
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        
        //if get out of the screen Die
        if (transform.position.x <= -11.0f)
        {
            Die();
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("patoEnem");
        //if collides with player Die
        if (other.CompareTag("Player"))      
            Die();
    }

    public void Die()
    {
        //instantiazion of the explosion and his duration
        GameObject fumeExplosionAux = (GameObject)Instantiate(fumeExplosion, transform.position, transform.rotation);
        Destroy(fumeExplosionAux, 0.5F);

        Destroy(this.gameObject);

    }
}
