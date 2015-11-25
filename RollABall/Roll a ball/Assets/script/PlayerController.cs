using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


    public float speed = 1f;
    private Rigidbody rb;
    private int count;
    public Text countText;

	// Use this for initialization

	void Start () {

        rb = GetComponent<Rigidbody>();
        countText.text = "Count:" + count;
    }
	
	// Update is called once per frame
	void Update () {
	
	
    }

    void FixedUpdate()
    {

        float moveVertical = Input.GetAxis("Vertical") ;
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("pick up"))
        {

            other.gameObject.SetActive(false);
            count++;
            countText.text = "Count:" + count;
        }



    }


}
