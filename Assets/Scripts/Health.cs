using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code by Addison Sharp

public class Health : MonoBehaviour
{
    // Amount of health
    public int health;
    public int maxHealth; 
    public virtual void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}