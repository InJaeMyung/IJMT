using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	GameObject[] enemies;
	public GameObject enemy;
	public GameObject player;
	private int spawnCount;
	private int Num;
	private Vector3 spawnPoint;
	private Vector3 ptarget;
	int enemySize=10;



	// Use this for initialization
	void Start () {
		spawnCount = 10;
		ptarget = player.transform.position;
		enemies = new GameObject[enemySize];
		for (int i = 0; i < enemySize; ++i) {
			enemies [i] = Instantiate (enemy)as GameObject;
			enemies [i].SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//enemies = GameObject.FindGameObjectsWithTag ("Enemy");


		if (spawnCount > 0) {
			spawnEnemy ();
			}
		if (spawnCount <= 0) {
			return;
		}





	}
	void spawnEnemy()
	{
		for (int i = 0; i < enemySize; ++i) {
			spawnPoint.x = ptarget.x + Random.Range (-50,50);
			spawnPoint.y = 0.5f;
			spawnPoint.z = ptarget.z + Random.Range (-50, 50);
			enemies [i].transform.position = spawnPoint;
			enemies [i].SetActive (true);
			enemies [i].name = "Enemy_" + Num;
			++Num;
			spawnCount--;
		}

	}
}
