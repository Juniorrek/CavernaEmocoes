using UnityEngine;
using System.Collections;

public class arm_voltar : MonoBehaviour {
	public float speed;
	bool voltar = false;
	float vel = 0;
	//esse script faz com que a picareta volte para o jogador, como um bumerangue ;)
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		if (voltar == false) {
			if (rb.velocity.x <= 1f && rb.velocity.x >= -1f) {
				voltar = true;
				rb.velocity.Set (0, 0, 0);
				print ("aeaeae");
			}
				
		} else {
			if (vel < speed) {
				vel += 0.2f;
			}

			rb.drag = 0;
			transform.position = Vector3.MoveTowards (transform.position, GameObject.Find ("Jogador").transform.position, vel * Time.deltaTime);
		}






	}
}
