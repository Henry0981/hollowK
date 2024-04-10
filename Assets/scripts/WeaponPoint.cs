using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponPoint : MonoBehaviour
{
    [SerializeField] GameObject BulletPrefab;

    [SerializeField] Transform gunTransform;
    [SerializeField] Transform gunObject;

    float ShotTimer = 0;

    [SerializeField] float timeBetweenShots = 0.5f;

    void Update()
    {
        ShotTimer += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") > 0 && ShotTimer > timeBetweenShots)
        {
            Instantiate(BulletPrefab, gunTransform.position, gunTransform.rotation);
            ShotTimer = 0;
        }

        // istället för quanternion identity så använder vapnets roation (typ transform.rotation,)


    }
}
