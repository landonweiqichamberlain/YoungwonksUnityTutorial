using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private CharacterController controller;
    public int speed = 7;
    
    public float gravity = -3f;

    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        bool isGrounded = controller.isGrounded;

        if (Input.GetKey("w"))
            move += transform.forward;
        if (Input.GetKey("s"))
            move += -transform.forward;
        if (Input.GetKey("a"))
            move += -transform.right;
        if (Input.GetKey("d"))
            move += transform.right;
        if (Input.GetKeyDown("space") & isGrounded)
        {
            controller.Move(Vector3.up * 400 * Time.deltaTime);
        }
        
        controller.Move(move * speed * Time.deltaTime);
        
        


        controller.Move(Vector3.up * gravity * Time.deltaTime);
        
        
        
        
        
        
        
        
        

     


        
    }

    
}