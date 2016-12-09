#pragma strict

var puloDuplo : boolean;
var velocidade : float;
var velocidadeMax : float;
var puloDuploTxt : UI.Text;
var noChao : boolean;

function Start () {
	velocidade = 2;
	puloDuplo = false;
	noChao = false;
}

function Update () {
	var colisao : Collider[];
	var pos : Vector3;


	//movimento lateral

	//essa parte serve para o personagem começar lento e acelerar
	if (Input.GetAxis("Horizontal")){
		if (velocidade < velocidadeMax)
			velocidade += 0.1;
	}
	else{//e o personagem não para derrepente, ele desacelera
		if (velocidade > 2)
			velocidade -= 0.1;
	}


	transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * velocidade, 0f, 0f);

	puloDuploTxt.text = puloDuplo.ToString();


	//detecta se há colisão
	colisao = Physics.OverlapSphere(new Vector3(transform.position.x,transform.position.y-1,transform.position.z), 0.01f /* Radius */);

	if (colisao.length > 1){
		noChao = true;
		puloDuplo = true;
	}
	else{
		noChao = false;
	}



	//pulo
	if(Input.GetButtonDown("Jump")) {
		if (noChao){
			GetComponent.<Rigidbody>().velocity.y = clamp(velocidade*1.6,9,10);
			noChao = false;
		}
		else if (puloDuplo){
			puloDuplo = false;
			GetComponent.<Rigidbody>().velocity.y = clamp(velocidade*1.6,9,10);
		}

	}


}




//função clamp: mantem um valor entre o minimo e o máximo
function clamp(val : float, min : float, max : float){
	if (val > max){
		return max;
	} else if (val < min)
		return min;
	else
		return val;
}