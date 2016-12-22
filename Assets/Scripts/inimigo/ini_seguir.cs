using UnityEngine;
using System.Collections;

public class ini_seguir : MonoBehaviour {
	//objeto se move na direção do jogador se a distancia for menor que a informada
	public float distancia = 10;
	public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(transform.position, GameObject.Find("Jogador").transform.position);
		if (distance < distancia) {
			transform.position = Vector3.MoveTowards (transform.position, GameObject.Find("Jogador").transform.position,speed *  Time.deltaTime);
		}
	}
}
