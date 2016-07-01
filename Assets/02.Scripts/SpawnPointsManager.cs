﻿using UnityEngine;
using System.Collections;

public class SpawnPointsManager : MonoBehaviour {
	GameObject[] enemies1;
	public GameObject enemy;

	//public GameObject spawn1;

	//public Transform[] spawnPoints;

	//private int spawnCount;
	private Vector3 spawn1target;
	Vector3 spawnPoint1;

	bool isSpawn = true;

	private int Num;
	public int enemySize;

	// Use this for initialization
	void Start () {
		//spawnCount = 10;

		enemies1 = new GameObject[enemySize];
	
		spawn1target = gameObject.transform.position;

		for (int i = 0; i < enemySize; ++i) {
			enemies1 [i] = Instantiate (enemy)as GameObject;
			enemies1 [i].transform.parent = gameObject.transform;
			enemies1 [i].SetActive (false);
		}
	}
	void pointsSpawn()
	{
		
		for (int i = 0; i < enemySize; ++i) {

			spawnPoint1 = spawn1target;

			spawnPoint1 = spawnPoint1 + Vector3.forward * Random.Range (-4, 4) + Vector3.right * Random.Range (-4, 4);

			enemies1 [i].transform.position = spawnPoint1;
			enemies1 [i].SetActive (true);
		}

		transform.rotation = Quaternion.Euler (new Vector3 (-30.0f, 0.0f, 0.0f));

		for (int i = 0; i < enemySize; ++i) {
			enemies1 [i].transform.rotation = Quaternion.identity;
		}


	}
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag=="Player")
		if(isSpawn){
			pointsSpawn ();
			isSpawn = false;
		}
	}

}
