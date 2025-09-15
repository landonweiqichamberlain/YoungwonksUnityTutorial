using UnityEngine;

public class TestCameraController : MonoBehaviour
{
    public Transform target;  
    public Vector3 offset;
    public float mouseSpeed = 5;
    public Transform pivotV;
    private float scale = 3;
    public Transform pivotH;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.position;
        pivotV.transform.position = target.transform.position;
        pivotH.transform.position = target.transform.position;
        
  
       pivotV.transform.parent = null;
       pivotH.transform.parent = null;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        pivotH.position = target.position;
        pivotV.position = target.position;

        //transform.position = target.position + offset;
        float horizontal = Input.GetAxis("Mouse X") * mouseSpeed;
        pivotH.Rotate(0, horizontal, 0);
        float desiredYAngle = pivotH.eulerAngles.y;
        float vertical  = Input.GetAxis("Mouse Y");
        pivotV.Rotate(-vertical, 0, 0);
        float desiredXAngle = pivotV.eulerAngles.x * scale;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = pivotH.position - (rotation * offset);
        transform.LookAt(pivotH.position);
        Vector3 angles = pivotV.localEulerAngles;

        if (angles.x > 180f)
            angles.x -= 360f;

        if (angles.x < -26f)
        {
            angles.x = -26f;
            pivotV.localEulerAngles = new Vector3(angles.x, 0f, 0f);
        }

        if (angles.x > 0f)
        {
            angles.x = 0f;
            pivotV.localEulerAngles = new Vector3(angles.x, 0f, 0f);
        }

            

    }
}