using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGenerator : MonoBehaviour {
    //Array of objects to spawn (note I've removed the private goods variable)
    public GameObject powerUp;

    //Time it takes to spawn power up
    [Space(3)]
    public float waitingForNextSpawn = 10;
    public float theCountdown = 10;

    // the range of X
    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;


    void Start()
    {
    }

    public void Update()
    {
        // timer to spawn the next power up
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnPowerUp();
            theCountdown = waitingForNextSpawn;
        }
    }

    void SpawnPowerUp()
    {
        // Defines the min and max ranges for x and y
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

        var newPowerUp = GameObject.Instantiate(powerUp);
        powerUp.transform.position = pos;
    }
}
