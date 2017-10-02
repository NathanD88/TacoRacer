using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour {
    private GameControlScript gcs;
    private pickupController puc;
    public GameObject player;
    public GameObject obj;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(puc.pickupCount == 4)
            {
                Debug.Log("game over");
                gcs.FinishedGame();
            }
            else
            {
                Debug.Log("missing tacos, you only have " + puc.pickupCount);
            }
        }
    }
    // Use this for initialization
    void Start () {
        puc = player.GetComponent<pickupController>();
        gcs = obj.GetComponent<GameControlScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
