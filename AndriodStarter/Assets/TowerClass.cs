using UnityEngine;
using System.Collections;

public class TowerClass : MonoBehaviour {
    public SphereCollider range;
    public GameObject target;
    public GameObject Projectile;
    public bool canShoot;
    public float shootDelay;
	// Use this for initialization
	void Start () {
        range = GetComponent<SphereCollider>();
        canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(target == null && other.gameObject.tag == "PathUnit")
        {
            target = other.gameObject;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == target)
        {
            var targetRotation = Quaternion.LookRotation(other.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5 * Time.deltaTime);
            //transform.LookAt(target.gameObject.transform);
            if(canShoot)
            {
                if(Projectile != null)
                {
                    GameObject Fire = Instantiate(Projectile, transform.position, Quaternion.identity) as GameObject;
                    Fire.GetComponent<ProjectileClass>().target = other.gameObject;
                }
                StartCoroutine("Shoot");
            }
        }
        if (target == null && other.gameObject.tag == "PathUnit")
        {
            target = other.gameObject;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == target)
        {
            target = null;
        }
    }
    IEnumerator Shoot()
    {
        canShoot = false;
        for(float i = 0; i < shootDelay; i+=0.1f)
        {
            yield return new WaitForSeconds(0.1f);
        }
        canShoot = true;
    }

}
