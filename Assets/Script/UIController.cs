using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

  public GameObject mainMenu;

  public void ButtonClick() {
    GameController.Instance.GameStart();
    mainMenu.SetActive(false);
  }
}
