using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edvin : MonoBehaviour
{

    [SerializeField] Transform feet;

    [SerializeField] float groundRadius = 0.2f;

    [SerializeField] LayerMask groundLayer;

    [SerializeField] float speed = 10;

    [SerializeField] float jumpForce;

    [SerializeField] float DashForce;

    float dashtimer;

    [SerializeField] float dashcooldown;

    bool isGrounded;

    public Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // dashtimer += Time.deltaTime;
        // if (dashtimer >= dashcooldown)
        // {
        //     dashtimer = 0;

        // }

        // float moveX = Input.GetAxisRaw("Horizontal");

        // Vector2 movement = new Vector2(moveX, 0) * speed * Time.deltaTime;

        // transform.Translate(movement);

        float xMovement = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(xMovement, 0) * speed * Time.deltaTime;
        // transform.Translate(movement);
        transform.position += movement;


        isGrounded = Physics2D.OverlapCircle(feet.position, groundRadius, groundLayer);

        if (isGrounded && Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.L))
        // {
        //     GetComponent<Rigidbody2D>().AddForce(Vector2.right * DashForce, ForceMode2D.Impulse);
        // }

        // if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.L))
        // {
        //     GetComponent<Rigidbody2D>().AddForce(Vector2.left * DashForce, ForceMode2D.Impulse);
        // }
        //  groundcheck
        // om groundchek och y movemenT ÖVER NOLl lägg till kraft uppåt

    }
    void OnDrawGizmos()
    {
        if (isGrounded) { Gizmos.color = Color.red; }
        else { Gizmos.color = Color.blue; }

        Gizmos.DrawWireSphere(feet.position, groundRadius);
    }
}
