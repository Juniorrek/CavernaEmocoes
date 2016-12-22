using UnityEngine;
using System.Collections;

public class arm_girar : MonoBehaviour {
	public float velocidade;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back * Time.deltaTime * velocidade);
	}
}
