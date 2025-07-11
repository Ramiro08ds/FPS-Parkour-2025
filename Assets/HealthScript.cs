using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int damage;
    public HealthManager healthManager;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpdateHealth(damage);
        }
    }
}


