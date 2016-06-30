using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {
	private int hp = 10;
	public bool isDead = false;



	// Use this for initialization
	void Start () {
		
	}
	void OnGUI()
	{
		float x = Screen.width / 2.0f - 100;
		Rect rect = new Rect (x, 10, 200, 25);
		GUI.Box (rect, "My Health : " + hp);
		if (isDead == false) {
			GUI.Box (rect, "My Health : " + hp);
		} else {
			GUI.Box (rect, "Game Over");
		}
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
