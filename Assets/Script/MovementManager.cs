using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    public float speed;
    private Vector3 nextTarget;

    // Update is called once per frame
    void Update()
    {

      //TODO: Rotate character to face the direction their going

      transform.position = Vector3.MoveTowards(transform.position, nextTarget, speed * Time.deltaTime);
    }


    public void SetNewTarget(Vector3 v) {
      nextTarget = v;
    }
}
