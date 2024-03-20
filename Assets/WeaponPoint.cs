using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPoint : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;

    [SerializeField] Transform gunTransform;

    float ShotTimer = 0;

    [SerializeField] float timeBetweenShots = 0.5f;

    void Update()
    {


        ShotTimer += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && ShotTimer > timeBetweenShots)
        {
            Instantiate(BulletPrefab, gunTransform.position, Quaternion.identity);
            ShotTimer = 0;
        }


    }
}
