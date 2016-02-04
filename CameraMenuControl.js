public var  currentMount : Transform;
public var  speedFactor : float = 0.1;

public var zoomFactor = 0.1;
public var cameraComp : Camera;
private var lastposition : Vector3;

private var newMount : Transform;


function Start ()
{
   lastposition = transform.position;
}

function Update ()
{
    if (currentMount != null)
    {
        transform.position = Vector3.Lerp(transform.position,currentMount.position,0.1);
        transform.rotation = Quaternion.Slerp(transform.rotation,currentMount.rotation,speedFactor);

        var velocity = Vector3.Magnitude(transform.position - lastposition);
        cameraComp.fieldOfView = 60 + velocity * zoomFactor;

        lastposition = transform.position;
    }
}

function setMount (newMount : Transform)
    {        
        currentMount = newMount;
    }