using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
    public Transform SpawnPoint;
    public Transform EndPoint;
    public GameObject Enemy;
	// Use this for initialization
	void Start () {
        StartCoroutine("SpawnEnemies");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator SpawnEnemies()
    {
        for(float i = 0; i < 5; i+= 1f)
        {
            Instantiate(Enemy, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(1f);

        }
    }
}
