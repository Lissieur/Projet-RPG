using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackPlayer : MonoBehaviour
{
    private GameObject Player;
    public Health health; 

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            health.TakeDamage(10);
        }
    }
}
