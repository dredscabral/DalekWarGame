using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    int health;
    // Use this for initialization
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemies")
        {

            Debug.Log("Enemy !!!");
            health--;
            Debug.Log(health);
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "PowerUp")
        {
            Debug.Log("Collecting Power Up");
            health++;

            Debug.Log(health);
            Destroy(col.gameObject);
        }
    }

}
