using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard turret purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void AnotherStandardTurret()
    {
        Debug.Log("Another turret purchased");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
