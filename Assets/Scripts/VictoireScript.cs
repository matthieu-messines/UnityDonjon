using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoireScript : MonoBehaviour {

	void OnTriggerEnter(Collider c)
    {
        SceneManager.LoadScene("WinScene");
    }
}
