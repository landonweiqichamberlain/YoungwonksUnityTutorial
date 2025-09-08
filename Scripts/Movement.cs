using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private CharacterController controller;
    public int speed = 7;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            transform.LookAt(transform.position + new Vector3(0,0,1));
        }
        if (Input.GetKey("s"))
        {
            controller.Move(Vector3.back * speed * Time.deltaTime);
            transform.LookAt(transform.position + new Vector3(0,0,-1));
        }
        if (Input.GetKey("a"))
        {
            controller.Move(Vector3.left * speed * Time.deltaTime);
            transform.LookAt(transform.position + new Vector3(-1,0,0));
        }
        if (Input.GetKey("d"))
        {
            controller.Move(Vector3.right * speed * Time.deltaTime);
            transform.LookAt(transform.position + new Vector3(1,0,0));
        }
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Hit");
        transform.position = new Vector3(17.86f, 2.81f, 9.35f);

    }
}
