using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanceScript : MonoBehaviour {

    public int DirectionX, DirectionY, DirectionZ;
    public float Speed;
    private bool IsMoving;
    private int degats;

    void Start()
    {
        IsMoving = false;
        Speed = 1000;
        degats = 1;
    }

    public void Use()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(DirectionX * Speed, DirectionY * Speed, DirectionZ * Speed));
        IsMoving = true;
        Destroy(gameObject,2);
    }

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            c.gameObject.GetComponent<PlayerScript>().Damage(degats);
        }
        else if (c.gameObject.tag == "Enemy")
        {
            c.gameObject.GetComponent<EnemyScript>().Damage(degats);
        }
        Destroy(gameObject);
    }

    public bool GetIsMoving()
    {
        return IsMoving;
    }
}
