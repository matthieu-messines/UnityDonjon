using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptGeneral : MonoBehaviour {

	public bool Pause;
    private GameObject player;

	void Start(){
		Pause = false;
        player = GameObject.Find("Player");
	}

	public void begin(){
		SceneManager.LoadScene("MainScene");
	}

	public void resume(){
		Pause = !Pause;
	}

	public void exit(){
		Application.Quit();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (!Pause) {
				SceneManager.LoadScene("PauseScene", LoadSceneMode.Additive);
			}else {
				SceneManager.UnloadSceneAsync("PauseScene");
			}
			Pause = !Pause;
		}

        if (player.GetComponent<PlayerScript>().GetPvCurrent()<=0)
        {
            SceneManager.LoadScene("DeathScene");
        }
	}
}
