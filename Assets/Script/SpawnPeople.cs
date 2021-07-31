using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnPeople : MonoBehaviour
{

    [SerializeField] private GameObject personPrefab;

    public GameObject startWaypoint;
    public TextMeshProUGUI startCountText;

    public int time;

    private int peopleCount;

    //Temp
    public bool spawn;

    void Start() {
      peopleCount = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn) {
          StartCoroutine("SpawnGroup");
          spawn = false;
        }
    }


    public void ToggleSpawn() {
      StartCoroutine("SpawnGroup");
    }


    private IEnumerator SpawnGroup() {

      for (int i=0; i<3; i++) {

        for (int j=0; j<5; j++) {

          GameObject person = Instantiate(personPrefab, transform.position, Quaternion.identity);
          person.GetComponent<MovementManager>().SetNewTarget(startWaypoint.transform.position);
          peopleCount--;
          startCountText.SetText(peopleCount.ToString());
          yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(time);
      }
    }
}
