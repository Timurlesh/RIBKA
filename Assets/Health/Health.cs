using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
     private float startingHealth;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;

    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //live
        }
        else
        {
            //die
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
        TakeDamage(1);
        }
    }
}
