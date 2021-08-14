using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KukaController : MonoBehaviour
{
    public Animator anim;
   

    public void AnimStart (string animName)
    {
        anim.SetTrigger(animName);
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //print("one");
            anim.SetTrigger("anim1");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {  
            anim.SetTrigger("anim2");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("anim3");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("anim4", true);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetBool("anim4", false);
        }

        
    
        
    }
}
