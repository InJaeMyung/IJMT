using UnityEngine;
using System.Collections;

public class SpawnPointsManager : MonoBehaviour {
	GameObject[] enemies1;

	public GameObject spawn1;

	public GameObject enemy;
	public Transform[] spawnPoints;
	public Vector3 spawnPoint1;

	private int spawnCount;
	private Vector3 spawn1target;


	private int Num;
	public int enemySize;

	// Use this for initialization
	void Start () {
		spawnCount = 10;

		enemies1 = new GameObject[enemySize];
	

		spawn1target = spawn1.transform.position;


		for (int i = 0; i < enemySize; ++i) {
			enemies1 [i] = Instantiate (enemy)as GameObject;
			enemies1 [i].SetActive (false);
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

	}
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag=="Player")
			pointsSpawn ();
	}

}
