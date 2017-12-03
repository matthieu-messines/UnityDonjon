using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : CharacterScript {

    public GameObject lifebar;

    void Start () {
        pvCurrent = pvMax = 3;	
	}
	
    void Update () {
    }

    public new void Damage(int i)
    {
        base.Damage(i);
        Destroy(lifebar.GetComponent<GridLayoutGroup>().GetComponentInChildren<RawImage>());
    }
}
