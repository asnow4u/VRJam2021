using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{

    public List<GameObject> waypoints = new List<GameObject>();

    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Person") {

        GameObject prevWaypoint = col.gameObject.GetComponent<MovementManager>().GetPreWaypoint();

        if (waypoints.Count == 1) {

          //Check if Dead End
          if (prevWaypoint) {
            col.gameObject.GetComponent<MovementManager>().SetNewTarget(prevWaypoint);
            col.gameObject.GetComponent<MovementManager>().SetPrevWaypoint(gameObject);
          }

          //Starting Waypoint
          else {
            col.gameObject.GetComponent<MovementManager>().SetNewTarget(waypoints[0]);
            col.gameObject.GetComponent<MovementManager>().SetPrevWaypoint(gameObject);
          }
        }

        else {

          int randNum = Random.Range(0, waypoints.Count);

          while (waypoints[randNum] == prevWaypoint) {
            randNum = Random.Range(0, waypoints.Count);
          }

          col.gameObject.GetComponent<MovementManager>().SetNewTarget(waypoints[randNum]);
          col.gameObject.GetComponent<MovementManager>().SetPrevWaypoint(gameObject);
        }
      }
    }
}
