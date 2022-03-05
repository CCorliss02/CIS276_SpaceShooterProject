using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "boundry")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
