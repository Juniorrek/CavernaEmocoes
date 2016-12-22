using UnityEngine;
using System.Collections;

public class jog_atacar : MonoBehaviour {
	//esse script faz com que a picareta seja criada e jogada na direção que o jogador apertou por ultimo
	public GameObject picareta;
	public float velocidade = 100;
	float direcao = 1f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float velocidade_arremesso = velocidade;

		if (Input.GetButton ("Horizontal")) {
			velocidade_arremesso = velocidade * 1.01f + GetComponent<Rigidbody>().velocity.x;
			direcao = Input.GetAxis("Horizontal");
		}


			

		if (Input.GetButtonDown ("Fire")) {
			GameObject[] pic = GameObject.FindGameObjectsWithTag ("Picareta");
			if (pic.Length == 0){
				GameObject g = (GameObject) Instantiate (picareta,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);

				if (direcao >= 0) {
					g.GetComponent<Rigidbody> ().AddForce (new Vector3 (velocidade_arremesso,0,0));

				} else {
					g.GetComponent<Rigidbody> ().AddForce (new Vector3 (-velocidade_arremesso,0,0));

				}




			}
		}
	}
}
