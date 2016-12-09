using UnityEngine;
using System.Collections;

public class jog_atacar : MonoBehaviour {
	public GameObject picareta;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire")) {
			GameObject[] pic = GameObject.FindGameObjectsWithTag ("Picareta");
			if (pic.Length == 0){
				GameObject g = Instantiate (picareta);
				g.transform.position.Set (transform.position.x,transform.position.y,transform.position.z);

			}
		}
	}
}
