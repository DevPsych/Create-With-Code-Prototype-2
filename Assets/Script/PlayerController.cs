using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Input
    public float horizontalInput;
    public float verticalInput;

    private float speed = 15.0f;
    private float xRange = 20.0f;
    private float zRangeTop = 11.5f;
    private float zRangeBottom = 0;

    static public int lives = 3;
    static public int score = 0;

    public GameObject projectilePrefab;
    public GameObject projectileSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRangeTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }
        if (transform.position.z < -zRangeBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeBottom);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPosition.transform.position, projectilePrefab.transform.rotation);
        }
    }

    static public void Hit()
    {
        lives--;
        if (lives > 0)
        {
            Debug.Log(lives + " lives remaining");
        }
        else
        {
            Destroy(GameObject.FindWithTag("Player").gameObject);
            Debug.Log("Game Over!");
        }
    }

    static public void AddScore()
    {
        score++;
        Debug.Log(score  + " animals fed.");
    }
}
