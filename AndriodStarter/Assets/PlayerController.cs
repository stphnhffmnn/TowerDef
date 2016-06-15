using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public GameObject Tower;
    public float TouchTime = 1;
    Collider coll;
    public bool canSpawn;
    Vector3 Point;
    public bool isPlacingTower;
    // Use this for initialization
    void Start() {
        canSpawn = true;
        isPlacingTower = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                TouchTime = Time.time;
                Point = Camera.main.ScreenToWorldPoint(new Vector3((touch.position.x), (touch.position.y), 10f));
                transform.position = Point;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                Point = Camera.main.ScreenToWorldPoint(new Vector3((touch.position.x), (touch.position.y), 10f));
                transform.position = Point;
            }
            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {


                Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                Point = Camera.main.ScreenToWorldPoint(new Vector3((touch.position.x), (touch.position.y), 10f));
                transform.position = Point;
              

            }
        }

    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Path" || Other.tag == "Tower")
        {
            canSpawn = false;
        }
    }
    void OnTriggerStay(Collider Other)
    {
        if (Other.tag == "Path" || Other.tag == "Tower")
        {
            canSpawn = false;
        }

    }
    void OnTriggerExit(Collider Other)
    {
        if (Other.tag == "Path" || Other.tag == "Tower")
        {
            canSpawn = true;
        }
    }

}
