using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private float heartvalue;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == 'Player')
        {
            collision.GetComponent<Health>().addHealth(heartvalue);
            gameObject.SetActive(false);
        }
    }
}
