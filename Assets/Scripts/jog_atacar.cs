using UnityEngine;
using System.Collections;

public class jog_atacar : MonoBehaviour {
	public GameObject picareta;
	public float velocidade;
	float direcao = -1f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		direcao = Input.GetAxis("Horizontal");

		if (Input.GetButtonDown ("Fire")) {
			GameObject[] pic = GameObject.FindGameObjectsWithTag ("Picareta");
			if (pic.Length == 0){
				GameObject g = (GameObject)Instantiate (picareta,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);

				if (direcao > 0)

					g.GetComponent<Rigidbody>().AddForce(transform.forward * velocidade);
				else
					g.GetComponent<Rigidbody>().AddForce(transform.forward * -velocidade);

			}
		}
	}
}
