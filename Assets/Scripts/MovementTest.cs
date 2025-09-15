using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private CharacterController controller;
    public int speed = 7;
    
    public float gravity = -3f;
    
    public Animator playerAnimator;
    public Transform pivotH;
    public float rotateSpeed = 0.1f;
    public GameObject playerModel;

    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        bool isGrounded = controller.isGrounded;

        if (Input.GetKey("w"))
            move += -transform.forward;
        if (Input.GetKey("s"))
            move += transform.forward;
        if (Input.GetKey("a"))
            move += transform.right;
        if (Input.GetKey("d"))
            move += -transform.right;
        if (Input.GetKeyDown("space") & isGrounded)
        {
            controller.Move(Vector3.up * 400 * Time.deltaTime);
        }
        
        controller.Move(move * speed * Time.deltaTime);
        
        


        controller.Move(Vector3.up * gravity * Time.deltaTime);
        
        playerAnimator.SetBool("isGrounded", isGrounded);
        playerAnimator.SetFloat("speed", new Vector3(move.x,0,move.z).magnitude);
        
        if (move != Vector3.zero)
        {
            // 1. Make the Player rotation same as the pivotH rotation (y only)
            transform.rotation = Quaternion.Euler(0, pivotH.transform.eulerAngles.y, 0);

            // 2. Store the new rotation of the player model
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(move.x, 0, move.z));

            // 3. Slowly turn the player model from its current rotation to the new rotation
            playerModel.transform.rotation = Quaternion.Slerp(
                playerModel.transform.rotation,
                newRotation,
                rotateSpeed
            );
        }
        
        
        
        
        
        
        
        
        

     


        
    }

    
}