using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;
    private Color originalColor;
    private Renderer rend;
    private BuildManager buildManager;

    void Start(){
        buildManager = BuildManager.instance;
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnMouseDown(){
        if (EventSystem.current.IsPointerOverGameObject()){
            return;
        }
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        if (turretToBuild == null){
            // If nothing is selected yet, just return
            return;
        }
        if (turret != null){
            // Return if something is already there
            // TODO: Upgrade, etc
            return;
        }

        // Build a turret
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter(){
        if (EventSystem.current.IsPointerOverGameObject()){
            return;
        }
        rend.material.color = hoverColor;
    }

    void OnMouseExit(){
        rend.material.color = originalColor;
    }
}
