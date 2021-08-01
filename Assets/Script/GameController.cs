using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    private int numPeople;
    private bool allPeopleSpawned;

    void Awake() {
      if (Instance == null) {
        Instance = this;
      } else {
        Destroy(this);
      }
    }

    // Update is called once per frame
    void Update()
    {
      if (numPeople == 0 && allPeopleSpawned) {

        //TODO: UI Component
      }
    }


    public void ToggleAllPeopleSpawned() {
      allPeopleSpawned = true;
    }
}
