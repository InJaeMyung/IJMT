using UnityEngine;
using System.Collections;

public class csMove : MonoBehaviour {
	public Transform cameraTransform;
	public float moveSpeed = 10.0f;
	public float rotSpeed = 120.0f;
	public float gravity = -20.0f;

	CharacterController playerController=null;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//float amtMove = movSpeed * Time.deltaTime;
		//float amtRot = rotSpeed * Time.deltaTime;

		//float ver = Input.GetAxis ("Vertical");
		//float hor=Input.GetAxis("Horizontal");
		//float ang=Input.GetAxis("Horizontal");

		//transform.Translate (Vector3.forward * ver * amtMove);
		//transform.Translate (Vector3.right * hor * amtMove);
		//transform.Rotate (Vector3.up * ang * amtRot);

		float x = Input.GetAxis ("Horizontal");
		float y = transform.position.y;
		float z = Input.GetAxis ("Vertical");
		Vector3 moveDirection = new Vector3 (x, 0, z);
		moveDirection = cameraTransform.TransformDirection (moveDirection);
		moveDirection *= moveSpeed;

		playerController.Move (moveDirection * Time.deltaTime);
	}
}
