using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private Vector3 size = new Vector3(0.001f, 0.001f, 0.001f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Rotate(Vector3.right, horizontalInput);
        transform.Rotate(Vector3.up, verticalInput);

        if(Input.GetKey(KeyCode.Space))
            transform.localScale += size;
        else if (transform.localScale.x > 1 && transform.localScale.y > 1 && transform.localScale.z > 1)
            transform.localScale -= size;
    }
}
