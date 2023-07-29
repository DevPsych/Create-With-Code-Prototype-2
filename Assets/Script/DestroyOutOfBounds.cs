using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float xBound = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            PlayerController.Hit();
        }
        else if (transform.position.x > xBound)
        {
            Destroy(gameObject);
            PlayerController.Hit();
        }
        else if (transform.position.x < -xBound)
        {
            Destroy(gameObject);
            PlayerController.Hit();
        }
    }
}
