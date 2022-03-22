using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : Enemy
{
    public float speed;
    public Transform target;
    public float minimumDistance;    
    public float beginFollow;    


    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) < beginFollow) {
            if (Vector2.Distance(transform.position, target.position) > minimumDistance) {

                transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.fixedDeltaTime);
            } else {
                // Attack
            }
        }
    }
}
