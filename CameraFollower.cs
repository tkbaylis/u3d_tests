/*
 * Based on solutions by robertby and Danail at Unity Community
 * http://answers.unity3d.com/questions/418421/set-camera-orbit-rotation-on-mouse-direction-mouve.html
 * and John Mac
 * https://www.youtube.com/watch?v=PO5_aqapZXY
 */


using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
    private float distance;
    [SerializeField]
    private float distanceAway;
    [SerializeField]
    private float distanceUp;
    [SerializeField]
    private float smooth;

    [SerializeField]
    private float cameraSpeed;
    [SerializeField]
    private float xSpeed;
    [SerializeField]
    private float ySpeed;
    [SerializeField]
    private float yMinLimit;  //Lowest vertical angle in respect with the target.
    [SerializeField]
    private float yMaxLimit;
    [SerializeField]
    private float minDistance; //Min distance of the camera from the target
    [SerializeField]
    private float maxDistance;

    [SerializeField]
    private Transform follow;

    private Vector3 targetPosition;
    private float x = 0.0f;
    private float y = 0.0f;


    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (gameObject.GetComponent<Rigidbody>())
            gameObject.GetComponent<Rigidbody>().freezeRotation = true;
    }


    // Late Update is called once per frame, after all Update() events have occurred
    // Ideal for camera tracking
    void LateUpdate () {

        // Set to defaults if no values provided
        if (distance == 0.0) { distance = 20.0f; }
        if (cameraSpeed == 0.0) { cameraSpeed = 5.0f; }
        if (xSpeed == 0.0) { xSpeed = 175.0f; }
        if (ySpeed == 0.0) { ySpeed = 75.0f; }
        if (yMinLimit == 0.0) { yMinLimit = 20.0f; }
        if (yMaxLimit == 0.0) { yMaxLimit = 80.0f; }
        if (minDistance == 0.0) { minDistance = 5.0f; }
        if (maxDistance == 0.0) { maxDistance = 20.0f; }

        if (target && gameObject.GetComponent<Camera>())
        {

            //Zooming with mouse
            distance += Input.GetAxis("Mouse ScrollWheel") * distance;
            distance = Mathf.Clamp(distance, minDistance, maxDistance);

            //Detect mouse drag;
            if (Input.GetMouseButton(0))
            {
                x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
                y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
            }
            y = clampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            //Quaternion rotation = Quaternion.LookRotation(y, x, 0);
            //var rotation = Quaternion.LookRotation(y, x, 0);
            Quaternion position = rotation * Quaternion.Euler(0.0f + target.position.x, 0.0f + target.position.y, target.position.z - distance);

            Quaternion tpq = Quaternion.Euler(transform.position.x, transform.position.y, transform.position.z);

            //transform.translate = Quaternion.Slerp(tpq, position, cameraSpeed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * smooth);
            transform.rotation = rotation;
        }


        //// Vector between object (camera) and target
        //Vector3 relativePos = target.position - transform.position;
        ////// Vector between object (camera) and target, with offset for height
        ////Vector3 relativePos = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;

        //// Look rotation and Rotation of current object (camera)
        //Quaternion rotation = Quaternion.LookRotation(relativePos);
        //Quaternion current = transform.localRotation;

        //// Spherical interpolation (over a curve) to slowly rotate over time
        //transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        //// Move object (camera) forward over time
        ////transform.Translate(0, 0, 30 * Time.deltaTime);
        //transform.Translate(0, 0, 0);



        //// Setting the target position to be the correct offset from the hovercraft
        //targetPosition = follow.position + follow.up * distanceUp - follow.forward * distanceAway;

        //// Making a smooth transition between its current position and the position it want to be in
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);

        //// Make sure camera is looking the right way
        //transform.LookAt(follow);
    }

    private float clampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
