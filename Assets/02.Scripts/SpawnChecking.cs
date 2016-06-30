using UnityEngine;
using System.Collections;

public class SpawnChecking : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("ddddd");
	}
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		
		if (hit.collider.gameObject.tag == "Player") {
			Debug.Log ("충돌됨 스폰합니다.");	
		}
	}
}
