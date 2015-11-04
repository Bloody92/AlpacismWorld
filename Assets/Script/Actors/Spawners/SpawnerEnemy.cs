using UnityEngine;
using System.Collections;

public class SpawnrEnemy : Enemy
{
    public Enemy enemy01; //Prefab
    private float frameCounter;//Counter to instantiate
    public float frameRate; //Counter when instantiate
    private float randomObstacle;

    // Use this for initialization
    public SpawnrEnemy()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        frameCounter++;
        if (frameCounter >= frameRate)
        {
            randomObstacle = Random.Range(0.1f, 4.0f);

            if (randomObstacle < 5)
            {
                GameObject enemy = GameObject.Instantiate(enemy01, new Vector3(Random.Range(9.0f, 12.0f), Random.Range(-5.0f, 5.0f), 5.0f), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;
            }
           
            //Instantiation of de obstacles


        

            if (frameRate <= 140)
            {
                frameRate++;
            }

            frameCounter = 0;

        }

    }
}
