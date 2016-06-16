using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestMapController : MonoBehaviour {
    public Button[] QuestButtons = new Button[10];
    public Button levelMenu;
    public Transform LevelUpMenu;
    public bool levelUp;
	// Use this for initialization
    public int QuestsComplete = 0;
	void Start () {
        levelUp = false;
        QuestsComplete = PlayerPrefs.GetInt("QuestLevels");
	}
	
	// Update is called once per frame
	void Update () {
	    for(int i = 0; i < QuestsComplete+1; i++)
        {
            QuestButtons[i].GetComponent<QuestButtonClass>().isActive = true;
        }
        if (levelUp)//EcoMenu
        {
            LevelUpMenu.GetComponent<Animator>().Play("EcoMenuAnim");
            LevelUpMenu.GetComponent<Animator>().speed = 2;
           

        }
        if (!levelUp)
        {
            LevelUpMenu.GetComponent<Animator>().Play("EcoMenuClose");
            LevelUpMenu.GetComponent<Animator>().speed = 2;
         
        }

    }
    public void MenuMain()
    {
        Application.LoadLevel("MainMenu");
    }
    public void LevelUpMenuChange()
    {
        if(levelUp)
        {
            levelUp = false;
        }
        else { levelUp = true; }
    }

}
