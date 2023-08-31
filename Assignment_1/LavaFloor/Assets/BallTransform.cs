using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    private Vector3 transDirection = new Vector3(1,1,1);

    Vector3 MultiplyComponentWise(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x <= 0.5 || transform.localScale.y <= 0.5 || transform.localScale.z <= 0.5)
        {
            transDirection = new Vector3(1, 1, 1);
        }
        if (transform.localScale.x >= 4 || transform.localScale.y >= 4 || transform.localScale.z >= 4)
        {
            transDirection = new Vector3(-1, -1, -1);
        }

        transform.localScale += MultiplyComponentWise(scaleChange, transDirection);


    }
}
