#pragma strict

var stamina : float = 100;
var staminatxt : UI.Text;

function Start () {

}

function Update () {
	if(stamina < 100) {
		stamina += Time.deltaTime * 2;
	}
	staminatxt.text = stamina.ToString();
}