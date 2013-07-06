using UnityEngine;
using System.Collections;

public class MoveObj : MonoBehaviour {
	
	public float zSpeed = 1;
	public float xSpeed = 1;
	public float jumpImpulse = 3;
	private bool jumping = false;
	private int jmpCounter = 0;
	
	// Update is called once per frame
	void Update () {
		bool up = Input.GetKey(KeyCode.UpArrow);
		bool dwn = Input.GetKey(KeyCode.DownArrow);
		bool lft = Input.GetKey(KeyCode.LeftArrow);
		bool rht = Input.GetKey(KeyCode.RightArrow);
		bool spc = Input.GetKey(KeyCode.Space);
		
		if (up)
			transform.Translate(0, 0, zSpeed * Time.deltaTime);
		if (dwn)
			transform.Translate(0, 0, -zSpeed * Time.deltaTime);
		if (lft)
			transform.Translate(-xSpeed * Time.deltaTime, 0, 0);
		if (rht)
			transform.Translate(xSpeed * Time.deltaTime, 0, 0);
		
		if (spc && !jumping){
			if (jmpCounter >= 3){
				jumping = true;
				return;
			}
			
			jmpCounter++;
			transform.Translate(0, jumpImpulse * Time.deltaTime, 0);
		}
	}
	
	void OnCollisionEnter(Collision other){
		jumping = false;
		jmpCounter = 0;
	}
}
