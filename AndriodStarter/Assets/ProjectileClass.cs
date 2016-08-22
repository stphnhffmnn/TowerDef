using UnityEngine;
using System.Collections;

public class ProjectileClass : MonoBehaviour {
    public GameObject target;
    public float speed;
    public int damage;
    bool hadTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(target!= null)
        {
            hadTarget = true;
        }
        if (hadTarget && target == null)
        {
            Destroy(gameObject);
        }
        transform.LookAt(target.transform);
        transform.Translate(Vector3.forward*speed*Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == target)
        {
            target.GetComponent<EnemyScript>().health -= damage;
            Destroy(gameObject);
        }
    }

}
