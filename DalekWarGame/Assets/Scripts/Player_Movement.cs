using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    private Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveVelocity;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 270 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * 270 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.right * Time.deltaTime * moveSpeed;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}
