using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterHazard : MonoBehaviour {
    public Transform respawn;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = respawn.position;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
