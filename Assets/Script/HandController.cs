using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{

    public ActionBasedController controller;

    Animator animator;

    private float _gripCurrent;
    private float _gripTarget;

    private bool openHand;

    void Start() {
      openHand = false;
      animator = GetComponent<Animator>();
    }

    void Update() {
      
    }

    public void ToggleHand() {
      Debug.Log("Pressed");
      animator.SetBool("Pressed", openHand);
      openHand = !openHand;
    }

}
