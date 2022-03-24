using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : Enemy
{
    public Transform target;
    public float minimumDistance;    
    public float beginFollow;    
    public override void Start() {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        if (Vector2.Distance(transform.position, target.position) < beginFollow) {
            if (Vector2.Distance(transform.position, target.position) > minimumDistance) {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            } else {
                // Attack
            }
        } else {
        }
    }
}
