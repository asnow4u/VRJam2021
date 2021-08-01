using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    public GameObject StartObject;

    void Awake() {
      if (Instance == null) {
        Instance = this;
      } else {
        Destroy(this);
      }
    }

    public void GameStart() {
      StartObject.GetComponent<SpawnPeople>().ToggleSpawn();
    }

}
