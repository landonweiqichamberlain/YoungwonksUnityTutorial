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
        pivot.Rotate(0, vertical, 0);
        float desiredXAngle = pivot.eulerAngles.y * scale;
        print(desiredXAngle);
        Quaternion rotation = Quaternion.Euler(desiredXAngle - 10, desiredYAngle, 0);
        print(rotation);
        transform.position = target.position - (rotation * offset);
        transform.LookAt(target.position);
    }
}
