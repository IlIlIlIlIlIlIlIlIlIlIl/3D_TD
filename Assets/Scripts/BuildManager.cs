using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {
    public static BuildManager instance;

    void Awake(){
        if (instance != null){
            Debug.Log("More than one BuildManager in Scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileTurretPrefab;

    private GameObject turretToBuild;

    public void SetTurretToBuild(GameObject turret){
        turretToBuild = turret;
    }

    public GameObject GetTurretToBuild(){
        return turretToBuild;
    }
}
