using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lflipper : MonoBehaviour
{
    [SerializeField]
    public float spring = 40000;
    [SerializeField]
    public float damper = 1000;
    [SerializeField]
    public float openAngle = 45;
    [SerializeField]
    public float closeAngle = -45;

    private HingeJoint hj;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        hj = gameObject.GetComponent<HingeJoint>();
        hj.useSpring = true;
        rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
        openFlipper();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKeyUp(KeyCode.LeftArrow))      //離されたら実行
        {
            openFlipper();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))    //押されたら実行
        {
            closeFlipper();
        }
        
        
    }

    public void openFlipper()
    {
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.damper = damper;
        spr.targetPosition = openAngle;
        hj.spring = spr;
    }

    public void closeFlipper()
    {
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.damper = damper;
        spr.targetPosition = closeAngle;
        hj.spring = spr;
    }
}
