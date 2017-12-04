using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerScript : MonoBehaviour {

    public float Speed = 10;
    public bool IsOpen = false;
    public bool IsClose = false;
    public float timer;

    void Update()
    {
        
        if (IsOpen && timer<2)
        {
            timer += Time.deltaTime;
            float f = Speed * Time.deltaTime;
            transform.localPosition += new Vector3(0, -f, 0);
        }
        if (IsClose && timer<2)
        {
            timer += Time.deltaTime;
            float f = Speed * Time.deltaTime;
            transform.localPosition += new Vector3(0, f, 0);
        }
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (gameObject.name == "Porte")
            {
                timer = 0;
                IsOpen = true;
                IsClose = false;
            }
            else if(gameObject.name == "Fermeture")
            {
                Debug.Log("esfe"  +GetComponentInParent<GameObject>().GetComponent<DoorTriggerScript>().timer);
                GetComponentInParent<DoorTriggerScript>().timer = 0;
                GetComponentInParent<DoorTriggerScript>().IsOpen = false;
                GetComponentInParent<DoorTriggerScript>().IsClose = true;
            }
        }
    }
}
