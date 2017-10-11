using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player1RB;
    public Rigidbody player2RB;
    public Rigidbody player3RB;
    public Rigidbody player4RB;
    public int speed;

    public bool isPlayerOne;

    void Start ()
    {
        player1RB.GetComponent<Rigidbody>();
        player2RB.GetComponent<Rigidbody>();
        player3RB.GetComponent<Rigidbody>();
        player4RB.GetComponent<Rigidbody>();
        speed = 100;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isPlayerOne == true)
        {
            if (Input.GetKeyDown("w"))
            {
                player1RB.AddForce(transform.forward * speed);
            }
            if (Input.GetKeyDown("a"))
            {
                player1RB.AddForce(transform.right * -speed);
            }
            if (Input.GetKeyDown("d"))
            {
                player1RB.AddForce(transform.right * speed);
            }
            if (Input.GetKeyDown("s"))
            {
                player1RB.AddForce(transform.forward * -speed);
            }
        }
        if (isPlayerOne == false)
        {
            if (Input.GetKeyDown("uparrow"))
            {
                player1RB.AddForce(transform.forward * speed);
            }
            if (Input.GetKeyDown("leftarrow"))
            {
                player1RB.AddForce(transform.right * -speed);
            }
            if (Input.GetKeyDown("rightarrow"))
            {
                player1RB.AddForce(transform.right * speed);
            }
            if (Input.GetKeyDown("downarrow"))
            {
                player1RB.AddForce(transform.forward * -speed);
            }
        }
    }
}
