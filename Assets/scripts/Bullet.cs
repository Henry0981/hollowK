using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 150;

    // Update is called once per frame
    void Update()
    {
        print("HEY");
        // kod som gör att bullet går framåt. transform.forward.

        Vector3 movement = Vector3.right * bulletSpeed * Time.deltaTime;
        transform.Translate(movement);

            

    }
}
