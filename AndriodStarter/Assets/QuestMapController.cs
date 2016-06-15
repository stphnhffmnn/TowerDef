using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestMapController : MonoBehaviour {
    public Button[] QuestButtons = new Button[10];
	// Use this for initialization
    public int QuestsComplete = 0;
	void Start () {
        QuestsComplete = PlayerPrefs.GetInt("QuestLevels");
	}
	
	// Update is called once per frame
	void Update () {
	    for(int i = 0; i < QuestsComplete+1; i++)
        {
            QuestButtons[i].GetComponent<QuestButtonClass>().isActive = true;
        }
	}
    public void MenuMain()
    {
        Application.LoadLevel("MainMenu");
    }
}
