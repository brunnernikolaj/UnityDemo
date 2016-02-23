using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        Destroy(gameObject,Time.deltaTime);
        GameMaster.instance.BlockDestroyed();
    }
}
