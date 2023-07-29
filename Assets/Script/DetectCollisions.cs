using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerController.Hit();
        }
        else if (other.CompareTag("Food"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            PlayerController.AddScore();
        }
    }
}