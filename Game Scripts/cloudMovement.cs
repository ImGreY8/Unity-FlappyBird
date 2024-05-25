using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    // Game Variables 
    public int cloudVelocity = 3;
    public int deleteCloud = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position += (Vector3.left * cloudVelocity) * Time.deltaTime;

        if (transform.position.x < deleteCloud){

            Destroy(gameObject);
        }
    }
}
