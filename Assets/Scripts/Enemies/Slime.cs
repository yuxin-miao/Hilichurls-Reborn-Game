using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Slime : Enemy
{

  public override void Start()
  {
    base.Start();
    curHealth = 10;
    maxHealth = 10;
    enemyHealthBar.SetMaxHealth(maxHealth);

  }
}
