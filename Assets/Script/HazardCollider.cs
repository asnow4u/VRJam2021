using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardCollider : MonoBehaviour
{

    public GameObject bonePile;

    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Person") {

        Instantiate(bonePile, transform.position, transform.rotation);
        Destroy(col.gameObject);
      }
    }
}
