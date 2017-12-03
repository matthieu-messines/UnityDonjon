using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationScript : MonoBehaviour {

    private float jumpPower;
    private bool isGrounded;
    private Quaternion rotate;

    // Use this for initialization
    void Start () {
        rotate = transform.rotation;
        jumpPower = 200;
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawRay(transform.position, transform.forward.normalized * hit.distance, Color.red);
            GetComponent<LineRenderer>().SetPosition(0,transform.position+new Vector3(0,0,0));
            GetComponent<LineRenderer>().SetPosition(1, hit.point);
        }
    }

    void FixedUpdate () {
        if (Input.GetKey(KeyCode.Z))
        {
            rotate.eulerAngles = new Vector3(rotate.x,-45,rotate.w);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotate.eulerAngles = new Vector3(rotate.x, 135, rotate.w);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotate.eulerAngles = new Vector3(rotate.x, -135, rotate.w);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate.eulerAngles = new Vector3(rotate.x, 45, rotate.w);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpPower, 0));
        }

        transform.rotation = rotate;
        isGrounded = false;

    }

    void OnTriggerStay()
    {
        isGrounded = true;
    }
}
