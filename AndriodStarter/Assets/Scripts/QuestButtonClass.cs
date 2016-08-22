using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestButtonClass : MonoBehaviour
{
    public bool isActive = false;
    public int index;
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnClick());    
    }
    public void OnClick()
    {
        Debug.Log("Clicked");
        if(isActive)
        {
            Application.LoadLevel("TestLvl");
        }
    }
}
