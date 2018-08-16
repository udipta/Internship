using UnityEngine;

public class script : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	
	void FixedUpdate () {
		
		if(Input.GetKey("d"))
			rb.AddForce(10 , 2, 2);

		if(Input.GetKey("a"))
			rb.AddForce(-10, -1, -1);
		
		if(Input.GetKey("w"))
			rb.AddForce(1, 1, 10);
		
		if(Input.GetKey("s"))
			rb.AddForce(-1, -1, -10);
	}
}
