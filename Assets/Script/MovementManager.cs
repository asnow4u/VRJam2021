using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    public float speed;
    private GameObject nextTarget;

    private GameObject prevWaypoint;


    // Update is called once per frame
    void Update()
    {

      transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, 0, transform.position.z), new Vector3(nextTarget.transform.position.x, 0, nextTarget.transform.position.z), speed * Time.deltaTime);

      Vector3 diff = nextTarget.transform.position - transform.position;
      transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(diff.x, 0, diff.z)), 0.15F);
    }


    public void SetNewTarget(GameObject waypoint) {
      nextTarget = waypoint;
    }

    public void SetPrevWaypoint(GameObject waypoint) {
      prevWaypoint = waypoint;
    }

    public GameObject GetTarget() {
      return nextTarget;
    }

    public GameObject GetPreWaypoint() {
      return prevWaypoint;
    }

}
