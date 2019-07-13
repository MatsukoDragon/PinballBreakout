using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    //Vector3 XmaxSpeed (40.0f, 0f, 0f);

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("速度ベクトル:" + rb.velocity);

        Debug.Log("速度:" + rb.velocity.magnitude);
    }

    
    void FixedUpdate()
    {
        //速度がmaxSpeedを超えたなら
        
        
    }
    
}
