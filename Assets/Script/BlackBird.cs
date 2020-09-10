using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBird : Bird
{
    public GameObject explosion; // drag your explosion prefab here
    public float _boostForce = 10000f;

    public void OnCollisionExit2D()
    {
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(gameObject); // destroy the grenade
        Destroy(expl, 0.6f); // delete the explosion after 3 seconds
    }
}
