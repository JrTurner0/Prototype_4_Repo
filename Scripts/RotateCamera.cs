using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalImput = Input.GetAxis("Horizontal");
        
        transform.Rotate(Vector3.up, horizontalImput * rotationSpeed * Time.deltaTime);
    }
}
