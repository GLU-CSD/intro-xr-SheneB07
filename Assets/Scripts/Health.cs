using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Nodig om Image te gebruiken

public class Health : MonoBehaviour
{

    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthbarFill;

    void UpdateHealthBar()
    {
        healthbarFill.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

    public void RestoreHealth(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }
}