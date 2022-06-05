using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0,5)][SerializeField]
    float speed, jumpForce;
    Rigidbody rb;
    bool canJump;
    public LayerMask Ground;



    private void Awake()
    {
        gameObject.AddComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Physics.CheckSphere(transform.position, .5f, Ground))
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector3(h, jumpForce, v);
        }

        rb.AddForce(new Vector3(h, 0, v));

    }
}
