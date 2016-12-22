using UnityEngine;
using System.Collections;

public class destroi_picareta : MonoBehaviour {
	//esse script destroi a picareta quando ela chega perto do jogador
	int tempoRestante = 50;//tempo necessário para que a picareta não se destrua quando arremessada

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempoRestante--;
		float distance = Vector3.Distance (GameObject.Find("Jogador").transform.position, transform.position);

		if (tempoRestante < 1 && distance < 0.5f) {
			Destroy (gameObject);
		}
	}
}
