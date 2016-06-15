using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
    public int state = 0;
    public Transform TDMenu;
    public Transform EcoMenu;
    public Vector3 MainPos;
    public Vector3 EnemyPos;
    Camera cam;
    float time;
	// Use this for initialization
	void Start () {
        time = 1;
        MainPos = Camera.main.transform.position;
        cam = Camera.main;
        state = 2;
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
        if(state == 2)//EcoMenu
        {
            EcoMenu.GetComponent<Animator>().Play("EcoMenuAnim");
            EcoMenu.GetComponent<Animator>().speed = 13;
            Time.timeScale = 0.2f;
           
        }
        if(state != 2)
        {
            EcoMenu.GetComponent<Animator>().Play("EcoMenuClose");
            EcoMenu.GetComponent<Animator>().speed = 2;
            Time.timeScale = time;
        }

	}
    public void setState(int num)
    {

        if(num == 1 && state == 1)
        {
            state = 0;
        }
        else { state = num; }
        

    }
    public void DoubleSpeed()
    {
        if(time == 2)
        {
            time = 1;
        }
        else { time =2; }
    }
}
