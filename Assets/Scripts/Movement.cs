using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private CharacterController controller;
    public int speed = 7;
    public new AudioSource audio;
    
    
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey("w"))
            move += -transform.forward;
        if (Input.GetKey("s"))
            move += transform.forward;
        if (Input.GetKey("a"))
            move += transform.right;
        if (Input.GetKey("d"))
            move += -transform.right;
        
        controller.Move(move * speed * Time.deltaTime);
        


        


        
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        audio.Play();
        transform.position = new Vector3(17.86f, 2.81f, 9.35f);
        

    }
}
