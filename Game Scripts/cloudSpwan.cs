using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpwan : MonoBehaviour
{
    // reference game object
    public GameObject clouds;
    public float cloudInterval = 3;
    public float cloudTime = 0;
    public int randomYpos = 2;

    // Start is called before the first frame update
    void Start()
    {
        cloudSpwaning();
    }

    // Update is called once per frame
    void Update()
    {
        if (cloudTime < cloudInterval){

            cloudTime += Time.deltaTime;
        }else{
            cloudSpwaning();
            cloudTime = 0;
        }
    }

    public void cloudSpwaning(){

        // variables for random spwaning clouds in y space.
        float highPos = transform.position.y - randomYpos; 
        float lowPos = transform.position.y + randomYpos;

        Instantiate(clouds, new Vector3(transform.position.x, Random.Range(highPos, lowPos), 0), transform.rotation);
    }
}
