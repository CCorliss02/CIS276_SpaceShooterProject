using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    public int enemyHealth = 1;

    // Destroys or damages enemies if any of these conditions are met.

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "laser")
        {
            enemyHealth--;
        }

        if (other.gameObject.tag == "boundry")
        {
            Destroy(gameObject);
        }

        if (enemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    // Code to make the enemy move forward.

    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 0.005f, ForceMode.Impulse);
    }
}
