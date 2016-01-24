using UnityEngine;
using System.Collections;

public class always_face_camera : MonoBehaviour {

    // From Unity Community and Wiki
    // http://answers.unity3d.com/questions/181000/gui-text-always-facing-camera.html
    // http://wiki.unity3d.com/index.php?title=CameraFacingBillboard
    public Camera cameraToLookAt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = cameraToLookAt.transform.position - transform.position;
		v.x = v.z = 0.0f;
		transform.LookAt( cameraToLookAt.transform.position - v ); 
		transform.Rotate(0,180,0);
	}
}
