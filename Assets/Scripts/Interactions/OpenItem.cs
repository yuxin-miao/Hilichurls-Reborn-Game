using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItem : MonoBehaviour
{
    Animator animator;
    private void Start() {
        animator = GetComponent<Animator>();
    }
    public void IsOpenItem() {
        animator.SetTrigger("IsOpen");
        Destroy(gameObject, 2f);
    }

    
    public void DestroyItem() {
        Destroy(gameObject);
    }
}
