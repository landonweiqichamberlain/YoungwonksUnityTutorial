using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;  
    public Vector3 offset;
    public float mouseSpeed = 5;
    public Transform pivot;
    private float scale = 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.position;
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = target.position + offset;
        float horizontal = Input.GetAxis("Mouse X") * mouseSpeed;
        target.Rotate(0, horizontal, 0);
        float desiredYAngle = target.eulerAngles.y;
        float vertical  = Input.GetAxis("Mouse Y");
        vertical *= -1;
        pivot.Rotate(vertical, 0, 0);
        float desiredXAngle = pivot.eulerAngles.x * scale;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);
        transform.LookAt(target.position);
        Vector3 angles = pivot.localEulerAngles;

        if (angles.x > 180f)
            angles.x -= 360f;

        if (angles.x < -26f)
        {
            angles.x = -26f;
            pivot.localEulerAngles = new Vector3(angles.x, 0f, 0f);
        }

        if (angles.x > 0f)
        {
            angles.x = 0f;
            pivot.localEulerAngles = new Vector3(angles.x, 0f, 0f);
        }

            

    }
}
