using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableBlockControl : MonoBehaviour {

    int tileHealth;
    // Use this for initialization
    void Start()
    {
        tileHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {

        if (tileHealth <= 0)
        {

            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(tileHealth + "");
        if (collision.gameObject.tag == "Bullet")
            tileHealth--;

    }


}


