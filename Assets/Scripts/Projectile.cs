using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code by Addison Sharp

public class Projectile : MonoBehaviour
{
    public float speed; 
    public int damage;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
        // Check for health script on collison and damage it
        if (collision.gameObject.GetComponent<Health>() != null)
        {
            collision.gameObject.GetComponent<Health>().ChangeHealth(-damage);
        }

        // Destroy the projectile
        Destroy(gameObject);
    }
}
