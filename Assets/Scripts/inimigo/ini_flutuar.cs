using UnityEngine;
using System.Collections;

public class ini_flutuar : MonoBehaviour {
	//faz com que o inimigo fique "flutuando"
	//PRECISA QUE O INIMIGO TENHA UM PARENT 
	float y_inicio;
	float tempo = 0f;

	// Use this for initialization
	void Start () {
		y_inicio = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		tempo += 0.05f;

		transform.position = new Vector3 (transform.position.x, y_inicio + Mathf.Sin (tempo) * 0.7f, transform.position.z);

		
	}
}
