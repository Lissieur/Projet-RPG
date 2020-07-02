using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int maxMana = 100;
    public int currentMana;
    public ManaBar manaBar;
    public HealthBar healthBar;
    public Text text;
    public Text textmana;
    private string Vie;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }
    void Update()
    {
        Vie = currentHealth + ToString(); 
        text.text = Vie;
        textmana.text = currentMana + ToString();
        if (Input.GetKeyDown(("a")))
        {
            TakeMana(10);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        Died();
    }
    public void TakeMana(int spell)
    {
        currentMana -= spell;
        manaBar.SetMana(currentMana);
    }
    void Died()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(0); 
            Debug.Log("You are died");
        }
    }
}
