using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WallOut : MonoBehaviour
{
    int ball = 1;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="ball")
        {
            Destroy(other.gameObject);
            ball = 0;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ball==0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
   
}
