using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    void Start(){
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret(){
        Debug.Log("Standard Purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseMissileTurret(){
        Debug.Log("Missile Purchased");
        buildManager.SetTurretToBuild(buildManager.missileTurretPrefab);
    }
    // public void PurchaseAnotherStandardTurret(){
    //     Debug.Log("Anther Purchased");
    //     buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    // }
}
