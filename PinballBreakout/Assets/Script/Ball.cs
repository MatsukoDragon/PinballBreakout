using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="stage"&&other.gameObject.tag=="Block")
        {
            //ここに当たったら反対方向に跳ね返る処理(x?とz?軸？)

        }
    }
    
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
