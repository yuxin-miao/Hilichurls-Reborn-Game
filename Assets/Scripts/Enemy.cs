using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    Animator animator;
    public float health = 10f;
    public float maxHealth = 10f;

    public HealthBar healthBar;

    public float Health {
        set {
            health = value;

            if(health <= 0) {
                Defeated();
            }
        }
        get {
            return health;
        }
    }

    public float MaxHealth { 
        set {
            maxHealth = value;
        }
        get {
            return maxHealth;
        }
    }


    public void Start() {
        animator = GetComponent<Animator>();
        // healthBar.SetMaxHealth(maxHealth);
    }

    public void Defeated(){
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy() {
        Destroy(gameObject);
    }

    public void TakeDamage(float damage) {
        health -= damage;
        // healthBar.SetHealth(health);
    }
}
