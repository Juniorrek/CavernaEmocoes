using UnityEngine;
using System.Collections;

public class ini_flutuar : MonoBehaviour {
	float y_inicio;
	float tempo = 0f;
	Vector3 ultima_pos; //  
	// Use this for initialization
	void Start () {
		y_inicio = GetComponent<Rigidbody> ().position.y;
		ultima_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		tempo += 0.05f;
		if (ultima_pos.y != transform.position.y) {
			y_inicio -= ultima_pos.y - transform.position.y;
		}
		transform.position = new Vector3 (transform.position.x, y_inicio + Mathf.Sin (tempo) * 0.7f, transform.position.z);
		ultima_pos = transform.position;
		
	}
}
