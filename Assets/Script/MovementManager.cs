using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    public float speed;
    private Vector3 nextTarget;
    private Vector3 prevTarget;

    // Update is called once per frame
    void Update()
    {

      transform.position = Vector3.MoveTowards(transform.position, nextTarget, speed * Time.deltaTime);

      Vector3 diff = nextTarget - transform.position;
      transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(diff.x, 0, diff.z)), 0.15F);

    }


    public void SetNewTarget(Vector3 v) {
      nextTarget = v;
    }

    public void SetNewTargetAsPrevious() {
      nextTarget = prevTarget;
    }

    public void SetPrevTarget(Vector3 v) {
      prevTarget = v;
    }
}
