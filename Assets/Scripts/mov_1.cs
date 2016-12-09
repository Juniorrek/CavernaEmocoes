using UnityEngine;
using System.Collections;

public class mov_1 : MonoBehaviour {
	bool puloDuplo;
	float velocidade;
	public float velocidadeMax;
	//float velMax = velocidadeMax;
	bool noChao;


	// Use this for initialization
	void Start () {
		velocidade = 2;
		puloDuplo = false;
		noChao = false;
	}
	
	// Update is called once per frame
	void Update () {
		Collider[] colisao;

		float velMax = velocidadeMax;

		//movimento lateral
		//botão correr
		if (Input.GetButton("Run")){
			velMax = velocidadeMax *1.5f;
		}
		else{
			velMax = velocidadeMax;
		}
				
		if (velocidade > velMax)
			velocidade -= 1.0f;

		//essa parte serve para o personagem começar lento e acelerar
		if (Input.GetAxis ("Horizontal") != 0) {
			if (velocidade < velMax) {
				if (Input.GetButton("Run")){
					velocidade += 0.5f;
				} else {
					velocidade += 0.1f;
				}
		}
				
		}
		else{//e o personagem não para derrepente, ele desacelera
			if (velocidade > 2)
				velocidade -= 0.3f;
		}


		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * velocidade, 0f, 0f);




		//detecta se há colisão
		colisao = Physics.OverlapSphere(new Vector3(transform.position.x,transform.position.y-1,transform.position.z), 0.01f /* Radius */);

		if (colisao.Length > 1){
			noChao = true;
			puloDuplo = true;

		}
		else{
			noChao = false;
		}
		//Debug.Log ("teste");
		Rigidbody rb = GetComponent<Rigidbody> ();

		//pulo
		if(Input.GetButtonDown("Jump")) {
			
			if (noChao){
				
				rb.velocity = new Vector3(0,clamp(velocidade*1.6f,9f,11f),0);
				noChao = false;

			}
			else if (puloDuplo == true){
				
				puloDuplo = false;
				rb.velocity = new Vector3(0,clamp(velocidade*1.6f,9f,9f),0);
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
