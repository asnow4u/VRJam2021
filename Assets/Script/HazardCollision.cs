using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Interactable") {

        Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();

        if (rb.velocity.magnitude > 3f) {
          Destroy(gameObject);
        }
      }


      if (col.gameObject.tag == "Hazard") {
        Destroy(gameObject);
      }
    }
}
