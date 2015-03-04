using UnityEngine;
using System.Collections;

public class ClassicControl : MonoBehaviour {
	Vector2 velocity;
	Vector2 target;

	void Start (){
		velocity = new Vector2 (0, 0);
	}

	public void setLeft(){
		velocity.x=-1;
	}
	
	public void setRight(){
		velocity.x=1;
	}
	
	public void setUp(){
		velocity.y=1;
	}
	
	public void setDown(){
		velocity.y=-1;
	}

	public void setYtoZero(){
		velocity.y = 0;
	}

	public void setXtoZero(){
		velocity.x = 0;
	}

	public Vector2 GetVelocity(){
		return velocity;
	}

	public void Robba(){
		print ("Robba");
	}
}
