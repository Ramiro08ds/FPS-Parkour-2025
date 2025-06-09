using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIhealthManager : MonoBehaviour
{
    public TextMeshProUGUI txtHealth;

    public void UpdateHealthText(string health)
    {
        txtHealth.text = health;
    }
}
