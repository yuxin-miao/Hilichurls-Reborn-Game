using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enemy movement that will move around several pre-defined points
public class PatrolEnemy : Enemy
{
    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex;
    bool once = false;
    public override void Start() {
        base.Start();
    }


    public override void Update() {
        base.Start();
        if (transform.position != patrolPoints[currentPointIndex].position) {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
        } else {
            if (!once) {
                StartCoroutine(Wait());
                once = true;
            }
        }
    }

    IEnumerator Wait() {
        // suspend execution for waitTime seconds 
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length) {
            currentPointIndex++;
        } else {
            currentPointIndex = 0;
        }
        once = false;
    }
 }
