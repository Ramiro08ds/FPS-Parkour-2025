using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txt_Money;
    public TextMeshProUGUI txt_Health;

    public void UpdateMoneyText(string money)
    {
        txt_Money.text = "$" + money;
    }

     public void UpdateHealthText(string health)
    {
        txt_Health.text = health;
    }
}


