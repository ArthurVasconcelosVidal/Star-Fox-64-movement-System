using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour{
    PlayerControl playerControl;
    Vector2 leftStickValue;
    void Awake(){
        playerControl = new PlayerControl();

        playerControl.Moviment.Move.performed += ctx => {
            leftStickValue = ctx.ReadValue<Vector2>();
        };

        playerControl.Moviment.Move.canceled += ctx => {
            leftStickValue = Vector2.zero;
        };
    }

    public Vector2 LeftStick() {
        return leftStickValue;
    }

    void OnEnable(){
        playerControl.Moviment.Enable();
    }

    void OnDisable(){
        playerControl.Moviment.Disable();
    }
}
