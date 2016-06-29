using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {
	private int hp = 10;
	public bool isDead = false;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DamageByEnemy()
	{
		if (isDead) {
			return;
		}
			
		--hp;
		if (hp <= 0)
			isDead = true;
	}
}
