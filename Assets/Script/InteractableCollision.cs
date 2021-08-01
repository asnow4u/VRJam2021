using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCollision : MonoBehaviour
{

    public GameObject bonePile;

    private AudioSource splat;

    private Rigidbody rb;

    void Start() {
      rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Person") {

        if (rb.velocity.magnitude > 3f) {
          Instantiate(bonePile, transform.position, transform.rotation);
          Destroy(col.gameObject);

        } else {

          GameObject curTarget = col.gameObject.GetComponent<MovementManager>().GetTarget();
          GameObject prevTarget = col.gameObject.GetComponent<MovementManager>().GetPreWaypoint();

          col.gameObject.GetComponent<MovementManager>().SetPrevWaypoint(curTarget);
          col.gameObject.GetComponent<MovementManager>().SetNewTarget(prevTarget);
        }
      }
    }
}
