using UnityEngine;

public class movement : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(0, 500, 100);
		
	}
}
