#pragma strict

var rotateSpeed = 100;

function Update() {
    var horizontalDir = parseFloat(Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
    transform.Rotate(0, horizontalDir, 0);
}
