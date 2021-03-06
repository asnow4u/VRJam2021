using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishController : MonoBehaviour
{

    public TextMeshProUGUI finishCountText;

    private int peopleCount;

    // Start is called before the first frame update
    void Start()
    {
      peopleCount = 0;
    }


    private void OnTriggerEnter(Collider col) {

      if (col.gameObject.tag == "Person") {

        if ( peopleCount < 5) {
          Destroy(col.gameObject);
          peopleCount++;
          GetComponent<AudioSource>().Play(0);
          finishCountText.SetText(peopleCount.ToString());
        }

        else {

          GameObject curTarget = col.gameObject.GetComponent<MovementManager>().GetTarget();
          GameObject prevTarget = col.gameObject.GetComponent<MovementManager>().GetPreWaypoint();

          col.gameObject.GetComponent<MovementManager>().SetPrevWaypoint(curTarget);
          col.gameObject.GetComponent<MovementManager>().SetNewTarget(prevTarget);
        }
      }
    }
}
