using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    [SerializeField]
    Text text;

    [SerializeField]
    Text sText;

    public int score = 0;
    public override void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
        if (health == 0)
        {
            SceneManager.LoadScene("Game over"); 
        }
        text.text = "Health: " + health.ToString();

    }

    private void Update()
    {
        sText.text = "Score: " + score.ToString(); sText.text = "Score: " + score.ToString();
    }
}
