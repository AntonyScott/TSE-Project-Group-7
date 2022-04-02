using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform firingPoint;
    public BulletController bulletPrefab;




    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        BulletController NewBullet = Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation) as BulletController;
       
    }    
}
