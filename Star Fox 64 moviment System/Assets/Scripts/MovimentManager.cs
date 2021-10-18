using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MovimentManager : MonoBehaviour{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Vector2 screenLimits;
    [SerializeField] float velocity;
    [SerializeField] GameObject dollyCart;
    [SerializeField] [Range(0,1)] float rotationInterpolation;
    [SerializeField] float rotationSpeed;
    Vector3 direction;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        Move();
        SpaceShipRotation();
    }

    void LateUpdate(){
        ClampOnBoundaries();
    }

    void Move(){
        direction = dollyCart.transform.up * playerManager.inputManager.LeftStick().y + dollyCart.transform.right * playerManager.inputManager.LeftStick().x;
        transform.position += direction * velocity * Time.deltaTime;
    }

    void SpaceShipRotation() {
        if (direction != Vector3.zero){
            var newDir = Vector3.Lerp(transform.forward, direction, rotationInterpolation);
            //Quaternion newRotation = Quaternion.FromToRotation(transform.forward, newDir.normalized);
            Quaternion newRotation = Quaternion.LookRotation(newDir.normalized, transform.up);
            playerManager.meshObject.transform.rotation = Quaternion.Lerp(playerManager.meshObject.transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }
        else
            playerManager.meshObject.transform.rotation = Quaternion.Lerp(playerManager.meshObject.transform.rotation, transform.rotation, rotationSpeed * Time.deltaTime);
    }

    void ClampOnBoundaries() {
        Vector3 objectPosition = transform.localPosition;
        objectPosition.x = Mathf.Clamp(objectPosition.x, -screenLimits.x, screenLimits.x);
        objectPosition.y = Mathf.Clamp(objectPosition.y, -screenLimits.y, screenLimits.y);
        transform.localPosition = objectPosition;
    }

    void OnTriggerEnter(Collider other){
        Debug.Log(other.name);    
    }
    void OnDrawGizmos(){
        Gizmos.color = Color.cyan;
        //X debug
        Gizmos.DrawLine(dollyCart.transform.right * -screenLimits.x, dollyCart.transform.right * screenLimits.x);
        Gizmos.DrawLine(dollyCart.transform.up * -screenLimits.y, dollyCart.transform.up * screenLimits.y);

        //Square debug
        Gizmos.DrawLine(dollyCart.transform.right * -screenLimits.x + dollyCart.transform.up * screenLimits.y, dollyCart.transform.right * screenLimits.x + dollyCart.transform.up * screenLimits.y);
        Gizmos.DrawLine(dollyCart.transform.right * -screenLimits.x - dollyCart.transform.up * screenLimits.y, dollyCart.transform.right * screenLimits.x - dollyCart.transform.up * screenLimits.y);
        Gizmos.DrawLine(dollyCart.transform.up * -screenLimits.y + dollyCart.transform.right * -screenLimits.x, dollyCart.transform.up * screenLimits.y + dollyCart.transform.right * -screenLimits.x);
        Gizmos.DrawLine(dollyCart.transform.up * -screenLimits.y - dollyCart.transform.right * -screenLimits.x, dollyCart.transform.up * screenLimits.y - dollyCart.transform.right * -screenLimits.x);
    }
}
