using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{

    public List<GameObject> nextWaypoints = new List<GameObject>();
    public GameObject prevWaypoint;

    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Person") {

        //Check for dead end
        if (nextWaypoints.Count == 0) {
          col.gameObject.GetComponent<MovementManager>().SetNewTargetAsPrevious();
        }

        foreach(GameObject waypoint in nextWaypoints) {

          //Determin if something is blocking the path with raycast based on nextwaypoint
          int layermask = ~(1 << 9 | 1 << 10);

          if (!Physics.Linecast(transform.position, waypoint.transform.position, layermask)) {

            col.gameObject.GetComponent<MovementManager>().SetNewTarget(waypoint.transform.position);
            col.gameObject.GetComponent<MovementManager>().SetPrevTarget(transform.position);
          }
        }
      }
    }
}
