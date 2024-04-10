using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{

    public Vector2 Pointerposition;
    [HideInInspector] public Vector2 right;

    void Update()
    {
        Pointerposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        right = (Pointerposition - (Vector2)transform.position).normalized;
        transform.right = right;

    }
}
