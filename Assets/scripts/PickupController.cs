using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 delta_dist = transform.position - player.transform.position;
        rb.AddForce(5 * delta_dist.normalized);
	}
}
