using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;
    public UIManager UIManager;

    void Start()
    {
        UIManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateHealth(int DamageAmount)
    {
        if (health <= DamageAmount)
        {

            Debug.Log("Has muerto");
            return false;
        }
        
        
            health -= DamageAmount;
            UIManager.UpdateHealthText(health.ToString());
            return true;
        
    }
}
