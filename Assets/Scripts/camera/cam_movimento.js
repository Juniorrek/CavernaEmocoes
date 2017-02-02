#pragma strict

var sceneCam : GameObject;
 sceneCam = GameObject.Find("MainCam");

function Start () {

}

function Update () {
	if (GameObject.Find("Jogador") != null)
	transform.position.x = GameObject.Find("Jogador").transform.position.x;
}