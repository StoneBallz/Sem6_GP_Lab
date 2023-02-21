using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force1 : MonoBehaviour
{
    void OnMouseDown (){
      GetComponent<Rigidbody>().AddForce(300,0,0);  
    }  
}
