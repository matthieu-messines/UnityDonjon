using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {

    private float speed;
    public Transform camera;
    private GameObject player;

    
    void Start (){
        speed = 0.1f;
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        camera.transform.position = new Vector3(player.transform.position.x+10, player.transform.position.y+14, player.transform.position.z-10);
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3();
        if (Input.GetKey(KeyCode.Z))
        {
            move.z += speed;
            move.x -= speed;

        }
        if (Input.GetKey(KeyCode.S))
        {
            move.z -= speed;
            move.x += speed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            move.z -= speed;
            move.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move.z += speed;
            move.x += speed;
        }
        

        transform.position += move;
        

    }

       
}
