using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Transform target;
    public float speed;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
