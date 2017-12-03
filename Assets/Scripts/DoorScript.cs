using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public float Speed = 10;
    public bool IsOpen = false;

    void Update()
    {
        isEnemyDead();
        if (IsOpen)
        {
            float f = Speed * Time.deltaTime;
            transform.localPosition += new Vector3(0, -f, 0);
        }
    }

    public void isEnemyDead()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length==0)
        {
            Destroy(gameObject, 2);
            IsOpen = true;
        }
    }
}
