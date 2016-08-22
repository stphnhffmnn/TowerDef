using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionController : MonoBehaviour {
    public int level = 0;
    public float EnemyHealth;
    public float PlayerHealth;
    public Slider healthbar;
	// Use this for initialization
	void Start () {
        healthbar.maxValue = PlayerHealth;
        healthbar.minValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
        healthbar.value = PlayerHealth;
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
