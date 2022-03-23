using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Animator animator;
    public float curHealth;
    public float maxHealth;
    Rigidbody2D enemy;

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


    public virtual void Start() {
        animator = GetComponent<Animator>();
        enemy = GetComponent<Rigidbody2D>();
    }
    public virtual void Update() {
        if (transform.hasChanged) {
            animator.SetBool("isMoving", true);
        } else {
            animator.SetBool("isMoving", false);

        }
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
