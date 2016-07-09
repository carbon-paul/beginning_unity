using UnityEngine;
using System.Collections;

public class ConstrainY : MonoBehaviour {

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }
}
