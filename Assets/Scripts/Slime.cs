using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Slime : Enemy
{
    private new void Start() {
        base.Start();
        health = 10;  
        maxHealth = 10;
    }
    
}
