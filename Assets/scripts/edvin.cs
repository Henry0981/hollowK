using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edvin : MonoBehaviour
{

    float speed = 2;
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(xMovement, 0).normalized * speed * Time.fixedDeltaTime;
        transform.Translate(movement);


    }
}
