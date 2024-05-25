using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{  
    public Rigidbody2D myRigidbody;
    public float birdVelocity;
    public logicScript logic;
    public bool birdCollision = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Checking for jump input
        if (Input.GetKeyDown(KeyCode.Space) && birdCollision)
        {
            myRigidbody.velocity = Vector2.up * birdVelocity;
        }

        // Camera Boundries 
        if(transform.position.y >= 13)
        {     
            myRigidbody.velocity = Vector2.down * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, 13, 0);
        }
        else if(transform.position.y <= -13)
        {
            transform.position = new Vector3(transform.position.x, -13, 0);
        }
    }   
    private void OnCollisionEnter2D(Collision2D collision)
    {      
            logic.gameOver();
            logic.playerScore += 0;
            birdCollision = false;  
    }
}
