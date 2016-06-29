using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
	public GameObject[] enemies;
	public int amount;
	public int spawnCount=2;
	private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		amount = enemies.Length;

		if (spawnCount != 0) {
			Invoke("spawnEnemy",2);
		}

		if (spawnCount <= 0) {
			return;
		}



	}
	void spawnEnemy()
	{
		spawnPoint.x = Random.Range (-100,100);
		spawnPoint.y = 0.5f;
		spawnPoint.z = Random.Range (-100, 100);
		Instantiate (enemies [UnityEngine.Random.Range (0, enemies.Length - 1)], spawnPoint, Quaternion.identity);
		spawnCount--;
	}
}
