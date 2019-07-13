using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockMaster : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int ObjCount = this.transform.childCount;
        Debug.Log(ObjCount);

        
        if(ObjCount==0)
        {
            SceneManager.LoadScene("Result");
        }
        
    }
}
