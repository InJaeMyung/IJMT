﻿using UnityEngine;
using System.Collections;

public class DeadSpider : MonoBehaviour {
	public float downSpeed = 0.5f;
	// Use this for initialization
	void Start () {
		StartCoroutine (DeadProcess ());
	}
	IEnumerator DeadProcess()
	{
		yield return new WaitForSeconds (2.0f);
		while (transform.position.y > -2.0f) {
			Vector3 temp = transform.position;
			temp.y -= downSpeed * Time.deltaTime;
			transform.position = temp;

			yield return new WaitForEndOfFrame ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
