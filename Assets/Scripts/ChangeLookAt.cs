using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject target;


    private void OnMouseDown()
    {

        LookAt.target = target;

        Camera.main.fieldOfView = Mathf.Clamp(40 * target.transform.localScale.x, -1000, 1000);
    }

    
}
