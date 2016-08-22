using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
    public int state = 0; // puased
    public bool paused;
    public Transform TDMenu;
    public Transform PauseMenu;
    public Vector3 MainPos;
    public Vector3 EnemyPos;
    Camera cam;
    float time;
	// Use this for initialization
	void Start () {
        time = 1;
        paused = false;
        MainPos = Camera.main.transform.position;
        cam = Camera.main;
        state = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if(state == 0) // TDPlayer
        {
            cam.transform.position = MainPos;
        }
        if (state == 1)// EnemyCam
        {
            cam.transform.position = EnemyPos;
        }
        if(paused)
        {
            PauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

	}
    public void setState()
    {

        if(state == 1)
        {
            state = 0;
        }
        else { state = 1; }
        

    }
    public void setPause()
    {
        if(paused)
        {
            paused = false;
        }
        else { paused = true; }
    }

    public void DoubleSpeed()
    {
        if(time == 2)
        {
            time = 1;
        }
        else { time =2; }
    }
    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
  
}
