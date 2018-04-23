using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratesCrontroller : MonoBehaviour {

    int tileHealth;
	// Use this for initialization
	void Start () {
        tileHealth = 3;
    }
	
	// Update is called once per frame
	void Update () {

        if (tileHealth == 0)
        {

            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
            tileHealth--;
    }

}
