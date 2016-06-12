using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    public int health;
    public float speed;
    public NavMeshAgent nav;
    public NavMeshPath path;
	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        nav.CalculatePath(GameObject.FindGameObjectWithTag("EndPoint").transform.position, path);
        nav.SetPath(path);
    }
	
	// Update is called once per frame
	void Update () {
        
        
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            Destroy(gameObject);
        }
    }

}
