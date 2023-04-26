using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int health;
    public static int maxHealth = 100;

    int timer = 2;

    private void Start()
    {
        health = maxHealth;
        Debug.Log("Starting Health: " + health);
    }

    private void Update()
    {
        StartCoroutine(DamageTick());
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            health = 0;
            Debug.Log(health);
        }
    }

    IEnumerator DamageTick()
    {
        TakeDamage(10);
        yield return new WaitForSeconds(timer);
        
        Debug.Log(health);
    }
}
