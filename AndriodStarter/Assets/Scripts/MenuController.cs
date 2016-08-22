using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(PlayerPrefs.GetInt("QuestLevels") <= 0)
        { PlayerPrefs.SetInt("QuestLevels", 3); }
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Quit()
    {
        Application.Quit();
    }
    public void Directions()
    {
        //activate Directions Image
    }
    public void DirectionsClose()
    {
        //Close Directions Image;
    }
    public void QuestMap()
    {
        Application.LoadLevel("QuestMap");

    }


}
