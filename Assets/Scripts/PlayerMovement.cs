using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Vspeed = 20;
    public float Hspeed = 10;
    public float jumpforce = 5;
    public CapsuleCollider col;
    public LayerMask groundLayers;
    private Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * Vspeed * VerticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * Hspeed * HorizontalInput);
        //transform.Rotate(Vector3.up * Time.deltaTime * Hspeed * HorizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
    /*private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
            col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
        // SITE: https://www.youtube.com/watch?v=vdOFUFMiPDU 
    }
    */
}
