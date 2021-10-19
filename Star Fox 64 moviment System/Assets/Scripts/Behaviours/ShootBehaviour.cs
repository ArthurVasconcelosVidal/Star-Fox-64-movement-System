using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour{
    Vector3 direction;
    [SerializeField] float velocity;
    [SerializeField] float timeToDestroy;

    void Start(){
        Invoke("SelfDestroy", timeToDestroy);
    }

    void Update(){
        transform.position += direction.normalized * velocity * Time.deltaTime;
    }

    public void ShootDirection(Vector3 direction) {
        this.direction = direction;
        transform.rotation = Quaternion.LookRotation(direction.normalized, transform.up) * transform.rotation;
    }

    void SelfDestroy() {
        Destroy(this.gameObject);
    }
}
