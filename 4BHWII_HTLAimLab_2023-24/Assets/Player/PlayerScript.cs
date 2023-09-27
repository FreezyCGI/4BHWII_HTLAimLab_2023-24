using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{
    public float movementSpeed = 1;
    public float jumpHeight = 10;
    public float mouseXSpeed = 1;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        float mouseXInput = Input.GetAxis("Mouse X");

        transform.position += transform.forward * verticalInput * movementSpeed;
        transform.position += transform.right * horizontalInput * movementSpeed;

        transform.Rotate(0, mouseXInput * mouseXSpeed, 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpHeight);
        }
    }
}
