using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public const maxHealth = 3;
    public Transform spawnPoint;
    public int points;

    
    void Start()
    {
        currentHealth = maxHealth;
    }

       public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("enemy is dead");
            //scoreManager.AddPoints(points);
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            currentHealth = maxHealth;
        }
    }

}
