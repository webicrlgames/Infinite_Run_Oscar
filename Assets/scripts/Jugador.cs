using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    public float playerSpeed = 2.0f;
    public float jumpForce = 0f;
    public bool touchthefloor = true;
    public bool alive = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
        Vector3 moveRelative = transform.TransformDirection(move) * playerSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + moveRelative);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetKeyDown(KeyCode.Space) && touchthefloor == true)
        {
            rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            touchthefloor = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            touchthefloor = true;
        }
        if (collision.gameObject.CompareTag("Death"))
        {
            alive = false;
            Destroy(gameObject);
        }
    }
}
