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
          peopleCount++;
          finishCountText.SetText(peopleCount.ToString());
          Destroy(col.gameObject);
        }
      }
    }
}
