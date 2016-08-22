﻿using UnityEngine;
using System.Collections;

public class EnemyHealthBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
        //BackgroundBar
        Vector3 screenPosition = Camera.current.WorldToScreenPoint(transform.position);// gets screen position.
        screenPosition.y = Screen.height - (screenPosition.y + 1);// inverts y
        Rect rect = new Rect(screenPosition.x - 50, screenPosition.y - 12, 100, 24);// makes a rect centered at the player ( 100x24 )
        GUI.Box(rect, "Enemy");
        Rect health = new Rect(screenPosition.x - 50, screenPosition.y - 12, 100/3, 24);
    }
}
