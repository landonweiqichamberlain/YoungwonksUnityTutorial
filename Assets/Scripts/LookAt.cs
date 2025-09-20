using Unity.VisualScripting;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    static public GameObject target;


    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform);
        }
    }
}
