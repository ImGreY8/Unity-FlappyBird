using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{   
    public GameObject pipe;
    public float interval = 3;
    private float timer = 0;
    public float randomYpos = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < interval)
        {
            timer += Time.deltaTime;
        } else 
        {
            spawnPipe();
            timer = 0;
        }
    }

    // Function to Spawn Pipes 
    public void spawnPipe()
    {
        float highestPoint = transform.position.y - randomYpos; 
        float lowestPoint = transform.position.y + randomYpos;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
