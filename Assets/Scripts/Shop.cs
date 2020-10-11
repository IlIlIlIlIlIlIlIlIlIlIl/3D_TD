using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    void Start(){
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret(){
        Debug.Log("Purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseOtherStandardTurret(){
        Debug.Log("Other Purchased");
        buildManager.SetTurretToBuild(buildManager.missileTurretPrefab);
    }
    // public void PurchaseAnotherStandardTurret(){
    //     Debug.Log("Anther Purchased");
    //     buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    // }
}
