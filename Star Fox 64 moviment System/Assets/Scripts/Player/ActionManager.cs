using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour{

    [Header("Aim")]
    [SerializeField] GameObject aimObject;

    [Header("Normal Shoot")]
    [SerializeField] GameObject[] shootPoints;
    [SerializeField] GameObject shootPrefab;


    public void Shoot() {
        foreach (var point in shootPoints){
            GameObject shootInstance = Instantiate(shootPrefab, point.transform.position, shootPrefab.transform.rotation);
            shootInstance.GetComponent<ShootBehaviour>().ShootDirection(aimObject.transform.position - transform.position);
        }
    }
    
}
