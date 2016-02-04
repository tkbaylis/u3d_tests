var cam1 : Camera;
var cam2 : Camera;
function Update () {
if(Input.GetKeyDown("1")){
cam1.enabled = true;
cam2.enabled = false;
}
if(Input.GetKeyDown("2")){
cam1.enabled = false;
cam2.enabled = true; }
}