using UnityEngine;
using System.Collections;

public class ele_descer : MonoBehaviour {
	public float distancia = 20f;
	public float velocidade = 5f;
	public GameObject jogador;
	bool criado = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (distancia > 0) {
			transform.Translate (0f, -1 * Time.deltaTime * velocidade, 0f);
			velocidade = clamp (velocidade, 1, distancia / 10);
			distancia--;
		} else {
			if (!criado) {
				GameObject g = (GameObject)Instantiate (jogador, new Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);
				g.GetComponent<Rigidbody> ().AddForce (new Vector3 (20, 20, 0));
				criado = true;
			}
		}
	
	}


	//função clamp: mantem um valor entre o minimo e o máximo
	float clamp(float val,float min,float max){
		if (val > max){
			return max;
		} else if (val < min)
			return min;
		else
			return val;
	}
}
