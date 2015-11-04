using UnityEngine;
using System.Collections;

public class SpawnerObstacles : Enemy {
    public Enemy obstacle01; //Prefab
    public Enemy obstacle02; //Prefab
    public GameObject obstacle03; //Prefab
    private float frameCounter;//Counter to instantiate
    public float frameRate; //Counter when instantiate
    private float speedRate;//Counter to increase the speed
    public float speedUp;//How many instantiations will pass before speed grow up
    private float randomObstacle;

    // Use this for initialization
    public SpawnerObstacles ()
    {
        frameCounter = 0;
        speedRate = 0;
    }
	
	// Update is called once per frame
	public void Update ()
    {
        frameCounter++;
        if (frameCounter >= frameRate)
        {
            randomObstacle = Random.Range(0.1f, 15.0f);

            if(randomObstacle < 5)
            {
                GameObject obstac = GameObject.Instantiate(obstacle01, new Vector3(Random.Range(9.0f, 12.0f), -4.5f, 5.0f), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;
            }
            else if (randomObstacle > 10)
            {
                GameObject obstac = GameObject.Instantiate(obstacle02, new Vector3(Random.Range(9.0f, 12.0f), -4.75f, 5.0f), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;
            }
            else
            {
                GameObject obstac = GameObject.Instantiate(obstacle03, new Vector3(Random.Range(9.0f, 12.0f), -4.75f, 5.0f), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;
            }
            //Instantiation of de obstacles


            if (obstacle01.speed <= 15)
                speedRate++;

            //if speedRate arrives at the same level of speedUp the speed of the objects grow up
            if ((speedRate >= speedUp) && (obstacle01.speed <= 14))
            {
                obstacle01.speed += 3.0f * Time.deltaTime;
                obstacle02.speed += 3.0f * Time.deltaTime;
                obstacle03.speed += 3.0f * Time.deltaTime;

                speedRate = 0;
            }

            if (frameRate <= 140)
            {
                frameRate++;
            }
            
            frameCounter = 0;
             
        }
       
    }
}
