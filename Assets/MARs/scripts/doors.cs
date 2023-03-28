using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{
    //flase = lukket, true = aaben
    public Animator anim;
    public string door;
    void OnTriggerEnter(){
        anim.SetBool(door,true);
    }
    void OnTriggerExit(){
        anim.SetBool(door,false);
    }
}
