using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TowerControllers : MonoBehaviour, IPointerDownHandler {
    public int index;
    public bool isActive;
    public GameObject playerController;
    public GameObject Tower;
    public GameObject Range;
    public GameObject TowerSpawn;
    Button button;
	// Use this for initialization
	void Start () {
        button = GetComponent<Button>();
        isActive = false;
        TowerSpawn = Instantiate<GameObject>(Tower);
        TowerSpawn.GetComponent<Collider>().enabled = false;
        TowerSpawn.SetActive(false);
       
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 point = playerController.transform.position;
        TowerSpawn.transform.position = point;
     
        if (isActive && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            TowerSpawn.SetActive(true);
            if (touch.phase == TouchPhase.Began)
            {  
                      
            }
            if (touch.phase == TouchPhase.Moved)
            {
                
            }
            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                TowerSpawn.SetActive(false);
                isActive = false;
                if (playerController.GetComponent<PlayerController>().canSpawn) { Instantiate(Tower, point, Quaternion.identity); }
            }
        }
	}
    public void OnPointerDown(PointerEventData eventData)
    {
        isActive = true;
    }


    public void OnClickAndDrag()
    {
       
    }
}
