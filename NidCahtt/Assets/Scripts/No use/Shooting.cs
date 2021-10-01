using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // ------ Variables ----------
    [SerializeField]
    private Transform shootingPoint;

    [SerializeField] 
    private GameObject projectile;
    
    
// ------ Functions ----------

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectile, shootingPoint.position, shootingPoint.rotation);
    }
}
