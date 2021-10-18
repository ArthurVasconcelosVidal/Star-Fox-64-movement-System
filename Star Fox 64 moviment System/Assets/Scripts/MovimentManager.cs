using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MovimentManager : MonoBehaviour{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Vector2 screenLimits;
    [SerializeField] float velocity;
    [SerializeField] GameObject dollyCart;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        Move();
        Debug.DrawLine(dollyCart.transform.right * -screenLimits.x, dollyCart.transform.right * screenLimits.x, Color.blue);
        Debug.DrawLine(dollyCart.transform.up * -screenLimits.y, dollyCart.transform.up * screenLimits.y, Color.red);
    }

    void LateUpdate(){
        ClampOnBoundaries();
    }

    void Move(){
        Vector3 direction = Vector3.up * playerManager.inputManager.LeftStick().y + Vector3.right * playerManager.inputManager.LeftStick().x;
        transform.Translate(direction * velocity * Time.deltaTime);
    }

    void ClampOnBoundaries() {
        Vector3 objectPosition = transform.localPosition;
        objectPosition.x = Mathf.Clamp(objectPosition.x, (dollyCart.transform.right * -screenLimits.x).x, (dollyCart.transform.right * screenLimits.x).x);
        objectPosition.y = Mathf.Clamp(objectPosition.y, (dollyCart.transform.up * -screenLimits.y).y, (dollyCart.transform.up * screenLimits.y).y);
        transform.localPosition = objectPosition;
        
        //X mark
        Debug.DrawLine(dollyCart.transform.right * -screenLimits.x, dollyCart.transform.right * screenLimits.x, Color.blue);
        Debug.DrawLine((dollyCart.transform.up * -screenLimits.y), dollyCart.transform.up * screenLimits.y, Color.red);
        
        //Square mark
        Debug.DrawLine(dollyCart.transform.right * -screenLimits.x + dollyCart.transform.up * screenLimits.y, dollyCart.transform.right * screenLimits.x + dollyCart.transform.up * screenLimits.y, Color.green);
        Debug.DrawLine(dollyCart.transform.right * -screenLimits.x - dollyCart.transform.up * screenLimits.y, dollyCart.transform.right * screenLimits.x - dollyCart.transform.up * screenLimits.y, Color.green);
        Debug.DrawLine(dollyCart.transform.up * -screenLimits.y + dollyCart.transform.right * -screenLimits.x, dollyCart.transform.up * screenLimits.y + dollyCart.transform.right * -screenLimits.x, Color.cyan);
        Debug.DrawLine(dollyCart.transform.up * -screenLimits.y - dollyCart.transform.right * -screenLimits.x, dollyCart.transform.up * screenLimits.y - dollyCart.transform.right * -screenLimits.x, Color.cyan);
    }

    void OnTriggerEnter(Collider other){
        Debug.Log(other.name);    
    }
}
