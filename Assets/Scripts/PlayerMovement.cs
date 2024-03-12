using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Transform groundCheck; //no number in this yet, position, rotation, scale for Transform
    [SerializeField] LayerMask ground; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
         
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed); 

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb .velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }
    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
    bool IsGrounded() 
    {
        bool check = Physics.CheckSphere(groundCheck.position, .1f, ground); //ground check is the game object, groundCheck is the public variable,
        // we placed Transform game object in ground check variable
        return check; 
    }
}
