using UnityEngine;
using System.Collections;

public class cam_mov : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("Player").Length > 0) 
			transform.position.x = GameObject.FindObjectsWithTag("Player")[0].transform.position.x;
	}


}
