using UnityEngine;
using System.Collections;

public class SpawnPointsManager : MonoBehaviour {
	GameObject[] enemies1;
	GameObject[] enemies2;
	GameObject[] enemies3;
	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;
	public GameObject enemy;
	public Transform[] spawnPoints;
	public Vector3 spawnPoint1;
	public Vector3 spawnPoint2;
	public Vector3 spawnPoint3;
	private int spawnCount;
	private Vector3 spawn1target;
	private Vector3 spawn2target;
	private Vector3 spawn3target;

	private int Num;
	int enemySize=10;

	// Use this for initialization
	void Start () {
		spawnCount = 10;

		enemies1 = new GameObject[enemySize];
		enemies2 = new GameObject[enemySize];
		enemies3 = new GameObject[enemySize];

		spawn1target = spawn1.transform.position;
		spawn2target = spawn2.transform.position;
		spawn3target = spawn3.transform.position;

		for (int i = 0; i < enemySize; ++i) {
			enemies1 [i] = Instantiate (enemy)as GameObject;
			enemies1 [i].SetActive (false);
		}
		for (int i = 0; i < enemySize; ++i) {
			enemies2 [i] = Instantiate (enemy)as GameObject;
			enemies2 [i].SetActive (false);
		}
		for (int i = 0; i < enemySize; ++i) {
			enemies3 [i] = Instantiate (enemy)as GameObject;
			enemies3 [i].SetActive (false);
		}

	}
	void pointsSpawn()
	{
		
		for (int i = 0; i < enemySize; ++i) {
			spawnPoint1.x = spawn1target.x + Random.Range (-10,10);
			spawnPoint1.y = 0.5f;
			spawnPoint1.z = spawn1target.z + Random.Range (-10, 10);
			enemies1 [i].transform.position = spawnPoint1;
			enemies1 [i].SetActive (true);
			enemies1 [i].name = "Enemy1_" + Num;
			++Num;
			spawnCount--;
		}
		for (int i = 0; i < enemySize; ++i) {
			spawnPoint2.x = spawn2target.x + Random.Range (-10,10);
			spawnPoint2.y = 0.5f;
			spawnPoint2.z = spawn2target.z + Random.Range (-10, 10);
			enemies2 [i].transform.position = spawnPoint2;
			enemies2 [i].SetActive (true);
			enemies2 [i].name = "Enemy2_" + Num;
			++Num;
			spawnCount--;
		}
		for (int i = 0; i < enemySize; ++i) {
			spawnPoint3.x = spawn3target.x + Random.Range (-10,10);
			spawnPoint3.y = 0.5f;
			spawnPoint3.z = spawn3target.z + Random.Range (-10, 10);
			enemies3 [i].transform.position = spawnPoint3;
			enemies3 [i].SetActive (true);
			enemies3 [i].name = "Enemy3_" + Num;
			++Num;
			spawnCount--;
		}
	}
	// Update is called once per frame
	void Update () {
		if (spawnCount > 0) {
			pointsSpawn ();
		}
		if (spawnCount <= 0) {
			return;
		}
	}
}
