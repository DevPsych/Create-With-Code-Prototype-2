using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 1.5f;

    // Update is called once per frame
    void Update()
    {
        //Lower cooldown time if it is greater than -0.1
        if (cooldownTime > -0.1)
        {
            cooldownTime -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldownTime < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.Log(cooldownTime);
            cooldownTime = 1.5f;
        } else if (Input.GetKeyDown(KeyCode.Space) && cooldownTime > 0)
        {
            Debug.Log("Can use ability in " + cooldownTime + " seconds.");
        }
    }
}
