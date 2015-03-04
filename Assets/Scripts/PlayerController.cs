using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public ClassicControl control;
	Vector2 velocity;
	public float speed;
	Animator anim;

	void Start () {
		anim = GetComponent <Animator>();
	}
	
	void Update () {
		anim.SetFloat ("XVel", control.GetVelocity ().x);
		anim.SetFloat ("YVel", control.GetVelocity ().y);
		rigidbody2D.velocity = control.GetVelocity () * speed * Time.deltaTime;
	}
}
