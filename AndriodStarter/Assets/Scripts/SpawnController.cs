using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {
    public int enemyWavesAmount;
    public int averageEnemyCount;
    public float difficultMultipler;
    public GameObject[] EnemiesToSpawn;
    public float UnitSpawnWaitTime;
    public float SpawnWaveDelay;
    int waveCounter;
    int UnitCounter;
    int SpawnAmount;
    int hardness;
    bool sendUnit;
    bool sendWave;
	// Use this for initialization
	void Start () {
        sendUnit = false;
        sendWave = true;
        waveCounter = 0;
        hardness = 1;
    }
	
	// Update is called once per frame
	void Update () {
	    if(waveCounter == enemyWavesAmount)
        {
            //game is done, won by holding the line
        }
        if(sendWave)
        {
            spawnWave();
            
        }
        if (sendUnit)
        {
            Instantiate(EnemiesToSpawn[Random.Range(0, EnemiesToSpawn.Length)], gameObject.transform.position, transform.rotation);
            UnitCounter++;
            StartCoroutine("SpawnTimer", UnitSpawnWaitTime);       
        }

    }
    public void spawnWave()
    {
        waveCounter++;
        SpawnAmount = averageEnemyCount + ((int)(Random.Range(-1, 2) * difficultMultipler));
        Debug.Log(SpawnAmount);
        UnitCounter = 0;
        sendWave = false;
        sendUnit = true;
    }
    IEnumerator SpawnTimer(float time)
    {
        sendUnit = false;
        for (float x = 0; x <= time; x += time)
        { yield return new WaitForSeconds(time); }
        sendUnit = true;
        if(UnitCounter >= SpawnAmount) { StartCoroutine("SpawnWaveTimer", SpawnWaveDelay); } 
    }
    IEnumerator SpawnWaveTimer(float time)
    {
        
        sendUnit = false;
        for (float a = 0; a < time; a += 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
        }
        sendUnit = false;
        sendWave = true;
    }

}
