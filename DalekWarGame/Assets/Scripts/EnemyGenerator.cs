using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public Transform blackHole1;
    public Transform blackHole2;
    public Transform blackHole3;
    public Transform blackHole4;
    float x = 0, y = 0;
    int randomNum;

    public GameObject enemy;
    public float spawnTime = 3f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawnEnemy", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        randomNum = Random.Range(1, 5);
    }

    void spawnEnemy()
    {

        switch (randomNum) {
            case 1:
                x = -11;
                y = 5;
                break;
            case 2:
                x = 11;
                y = 5;
                break;
            case 3:
                x = 11;
                y = -5;
                break;
            case 4:
                x = -11;
                y = -5;
                break;
            default:
                break;
        }
        var newEnemy = GameObject.Instantiate(enemy);
        enemy.transform.position = new Vector2(x, y);
    }
}