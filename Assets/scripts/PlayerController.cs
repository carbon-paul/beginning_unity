using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text count_text;
    public Text win_text;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        win_text.text = "";
    }

    void FixedUpdate()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        float move_vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(move_horizontal, 0, move_vertical);

        rb.AddForce(movement * speed);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 5, 0, ForceMode.Impulse);
            print("Jumped");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.CompareTag("PickUp"))
        {
            collision.collider.gameObject.SetActive(false);
            count += 1;
            SetCountText();
            print("HIT!");
        }
    }

    void SetCountText()
    {
        count_text.text = "Count: " + count.ToString();
        if(count >= 11)
        {
            win_text.text = "WIN!!!";
        }
    }
}
