using UnityEngine;
using System.Collections;

public class ini_andar : MonoBehaviour {
	//esse script faz com que o inimigo ande para o lado até encontrar um obstaculo, depois ele muda de direção
	public float velocidade = 5;
	public float direcao = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//anda
		transform.Translate(direcao * Time.deltaTime * velocidade, 0f, 0f);


		//verifica colisão
		Collider[] colisao;
		int col = 0;
		colisao = Physics.OverlapSphere(new Vector3(transform.position.x + (direcao * 0.5f),transform.position.y - 0.5f,transform.position.z),0.3f);

		for (int c = 0; c < colisao.Length; c++) {
			if (colisao [c].gameObject.tag == "plataforma") {
				col++;
				break;
			}
		}




		Collider[] colisao2;
		int col2 = 0;
		colisao2 = Physics.OverlapSphere(new Vector3(transform.position.x + (direcao * 0.7f),transform.position.y,transform.position.z),0.1f);

		for (int c = 0; c < colisao2.Length; c++) {
			if (colisao [c].gameObject.tag == "plataforma") {
				col2++;
				break;
			}
		}

		//muda a direção
		if (col2 != 0 || col == 0) {
			direcao = direcao * -1;
		}

	}
}
