using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiringScript : MonoBehaviour
{
    public GameObject Laser;
    public float cooldown = 1f;

    void Update()
    {
        GameObject laser;
        
        // Press F to fire.

        if (Input.GetButtonDown("Fire1"))
        {
            laser = Instantiate(Laser, transform);
            laser.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f, ForceMode.Impulse);
        }
    }
}
