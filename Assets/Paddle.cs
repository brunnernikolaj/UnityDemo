using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Paddle : MonoBehaviour {


    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Comment
        var newXPos = transform.position.x + (Input.GetAxis("Horizontal") * speed);

        var scale = Mathf.Clamp((Mathf.Abs(Input.GetAxis("Horizontal")) - 1),0.5f,1.0f);
        Mathf.
        transform.position = new Vector3(Mathf.Clamp(newXPos,-16,2.6f), transform.position.y,0);
        transform.DOScaleY(scale,0.2f);
	}
}
