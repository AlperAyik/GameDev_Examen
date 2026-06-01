using UnityEngine;

public class MissileManager : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform firePoint;

    public void ShootMissile()
    {
        Instantiate(
            missilePrefab,
            firePoint.position,
            firePoint.rotation
        );
    }
}