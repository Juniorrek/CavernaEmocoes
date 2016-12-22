#pragma strict

private var velocidade : float;
var noChao : boolean;
var doubleJump : boolean = false;

function Start () {
	velocidade = 5;
}

function Update () {
	//Movimentação na horizontal
	transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * velocidade, 0f, 0f);

	//Pulo
	if(Input.GetButtonDown("Jump")) {
		if(noChao){
			//GetComponent.<Rigidbody>().AddForce(transform.up * 250);
			GetComponent.<Rigidbody>().velocity.y = 5;
		} else if (GetComponent(personagem).stamina > 20 && !doubleJump) {
			//GetComponent.<Rigidbody>().AddForce(transform.up * 250);
			GetComponent.<Rigidbody>().velocity.y = 5;
			GetComponent(personagem).stamina -= 20;
			doubleJump = true;
		}
	}

	if(GetComponent.<Rigidbody>().velocity.y == 0) {
		noChao = true;
		doubleJump = false;
	} else {
		noChao = false;
	}
}