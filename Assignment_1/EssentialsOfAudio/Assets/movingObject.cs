using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingObject : MonoBehaviour
{
    public float movingDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        

        if (transform.position.x <= -10 || transform.position.x >= 10)
        {
            movingDistance = -movingDistance;
        }


        newPosition.x += movingDistance;
        transform.position = newPosition;

    }
}
