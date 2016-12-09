using UnityEngine;
using System.Collections;

public class ini_seguir : MonoBehaviour {
	public float distancia;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(transform.position, GameObject.Find("Jogador").transform.position);
		if (distance < distancia) {
			transform.position = Vector2.MoveTowards (transform.position, GameObject.Find("Jogador").transform.position,speed *  Time.deltaTime);
		}
	}
}
