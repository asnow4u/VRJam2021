﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardCollision : MonoBehaviour
{

    public GameObject bonePile;

    private AudioSource splat;

    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Interactable") {

        Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();

        if (rb.velocity.magnitude > 3f) {
          Instantiate(bonePile, transform.position, transform.rotation);
          Destroy(gameObject);

        } else {
          GetComponent<MovementManager>().SetNewTargetAsPrevious();
        }
      }


      if (col.gameObject.tag == "Hazard") {
        Instantiate(bonePile, transform.position, transform.rotation);
        Destroy(gameObject);
      }
    }
}
