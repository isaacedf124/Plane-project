using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Health
{
    public GameObject Projectile;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", .5F, .5F);
    }
    public override void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    void Shoot()
    {
        Instantiate(Projectile, transform.position, transform.rotation);
    }
}
