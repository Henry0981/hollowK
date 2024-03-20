using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{

    public Vector2 Pointerposition;

    void Update()
    {
        Pointerposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.right = (Pointerposition - (Vector2)transform.position).normalized;

    }
}
