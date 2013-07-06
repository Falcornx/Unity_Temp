using UnityEngine;
using System.Collections;

public class FollowObjWithOffset : MonoBehaviour {

	public GameObject obj;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		if (obj != null){
			transform.position = obj.transform.position + offset;
		}
	}
}
