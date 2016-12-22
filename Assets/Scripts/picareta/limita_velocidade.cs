using UnityEngine;
using System.Collections;

public class limita_velocidade : MonoBehaviour {
	//esse script limita a velocidade máxima da picareta, ou qualquer outro objeto

	public float maxSpeed = 40f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void FixedUpdate()
	{
		if(GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
		{
			GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
		}
	}
}
