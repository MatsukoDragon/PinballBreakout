using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rflipper : MonoBehaviour
{
    [SerializeField]
    public float spring = 40000;//バネの強さ
    [SerializeField]
    public float damper = 1000;//バネの戻りにくさ
    [SerializeField]
    public float openAngle = 45;//開いた時の角度
    [SerializeField]
    public float closeAngle = -45;//閉じたときの角度

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
        if (Input.GetKeyUp(KeyCode.RightArrow))         //離されたら実行
        {
            openFlipper();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))      //押されたら実行
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
