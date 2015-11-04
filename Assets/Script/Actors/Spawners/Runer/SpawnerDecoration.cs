using UnityEngine;
using System.Collections;

public class SpawnerDecoration : Enemy {
    public Enemy decoration01; //Prefab
    public Enemy decoration02; //Prefab
    public Enemy decoration03; //Prefab
    private float frameCounter;//Counter to instantiate
    public float frameRate; //Counter when instantiate
    private float speedRate;//Counter to increase the speed
    public float speedUp;//How many instantiations will pass before speed grow up

    // Use this for initialization
    public SpawnerDecoration()
    {
        frameCounter = 0;
        speedRate = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        frameCounter++;
        if (frameCounter >= frameRate)
        {
            //Instantiation of de decorations
            GameObject decor01 = GameObject.Instantiate(decoration01, new Vector3(Random.Range(9.0f, 30.0f), Random.Range(-3.0f, -2.2f), Random.Range(9.0f, 11.0f)), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;
            GameObject decor02 = GameObject.Instantiate(decoration02, new Vector3(Random.Range(9.0f, 30.0f), Random.Range(-0.3f, -2.7f), Random.Range(12.0f, 14.0f)), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;
            GameObject decor03 = GameObject.Instantiate(decoration03, new Vector3(Random.Range(9.0f, 30.0f), Random.Range(2.2f, 4.5f), Random.Range(14.5f, 16.0f)), Quaternion.Euler(0.0f, 0.0f, 0.0f)) as GameObject;

            if (decoration01.speed <= 15)
                speedRate++;

            //if speedRate arrives at the same level of speedUp the speed of the objects grow up
            if ((speedRate >= speedUp) && (decoration01.speed <= 14))
            {
                decoration01.speed += 1.0f * Time.deltaTime;
                decoration02.speed += 1.0f * Time.deltaTime;
                decoration03.speed += 1.0f * Time.deltaTime;
                speedRate = 0;
                //frameRate -= 15;// we do this for the instantiation are more normal
            }

            if (frameRate > 30)
            {
                frameRate--;
            }

            frameCounter = 0;

        }

    }
}
