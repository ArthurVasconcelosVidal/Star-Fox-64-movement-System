using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour{
    [SerializeField] PlayerManager playerManager;
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

        playerControl.Actions.ActionButton.performed += ctx =>{
            playerManager.actionManager.Shoot();
        };
    }

    public Vector2 LeftStick() {
        return leftStickValue;
    }

    void OnEnable(){
        playerControl.Moviment.Enable();
        playerControl.Actions.Enable();
    }

    void OnDisable(){
        playerControl.Moviment.Disable();
        playerControl.Actions.Disable();
    }
}
