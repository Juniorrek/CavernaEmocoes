using UnityEngine;
using System.Collections;

public class ini_voltar : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.position = Vector2.MoveTowards (transform.position, GameObject.Find("Jogador").transform.position,speed *  Time.deltaTime);

	}
}
