#pragma strict

var sceneCam : GameObject;
 sceneCam = GameObject.Find("MainCam");

function Start () {

}

function Update () {
	transform.position.x = GameObject.Find("Jogador").transform.position.x;
}