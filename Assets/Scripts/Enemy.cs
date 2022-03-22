using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    Animator animator;
    public float curHealth;
    public float maxHealth;


    public float Health {
        set {
            curHealth = value;

            if(curHealth <= 0) {
                Defeated();
            }
        }
        get {
            return curHealth;
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
    }

    public void Defeated(){
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy() {
        Destroy(gameObject);
    }

    public void TakeDamage(float damage) {
        curHealth -= damage;
        if(curHealth <= 0) {
            Defeated();
        }
    }
}
