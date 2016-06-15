using UnityEngine;
using System.Collections;

public class MissionController : MonoBehaviour {
    public int level = 0;
    public float EnemyHealth;
    public float PlayerHealth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(PlayerHealth <= 0)
        {
            Application.LoadLevel("QuestMap");
        }
        if(EnemyHealth <= 0)
        {
            if(level > PlayerPrefs.GetInt("QuestLevels"))
            {
                PlayerPrefs.SetInt("QuestLevels", level);
            }
            Application.LoadLevel("QuestMap");
        }
	    
	}
}
