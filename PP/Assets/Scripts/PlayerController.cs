using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private Rigidbody playerRb;
    private float zTopBound = 17;
    private float zBottomBound = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        if (transform.position.z < -zBottomBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBottomBound);
        }
        if (transform.position.z > zTopBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTopBound);
        }
    }
}
