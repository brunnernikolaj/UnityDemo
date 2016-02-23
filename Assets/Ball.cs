using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Rigidbody rb;

    public GameObject particleExplosion;

    private bool inPlay;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (!inPlay)
        {
            rb.AddForce(new Vector3(600f, 600f));
            inPlay = true;
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(particleExplosion, transform.position, Quaternion.identity);
    }
}
