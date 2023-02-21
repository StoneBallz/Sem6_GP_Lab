using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorArray : MonoBehaviour
{
    public Color[] arr=new Color[3];
    int i = 0;
    Renderer rend;
    void Start(){
         rend=GetComponent<Renderer>();
    }

    void OnMouseDown (){
        i++;
        if(i>=4){
            i=0;
        }
        rend.material.SetColor("_Color", arr[i]);

    }   
}
