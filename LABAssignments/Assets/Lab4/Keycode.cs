using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycode : MonoBehaviour
{
    Renderer rend;
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }
    void Update()
    {
        if(Input.GetKeyDown(UnityEngine.KeyCode.R)){
            rend.material.color=Color.red;
        }

        if(Input.GetKeyDown(UnityEngine.KeyCode.G)){
            rend.material.color=Color.green;
        }

        if(Input.GetKeyDown(UnityEngine.KeyCode.B)){
            rend.material.color=Color.blue;
        }

        if(Input.GetKeyDown(UnityEngine.KeyCode.Space)){
            Debug.Log("Space Clicked");
            for(int i=0; i<5; i++){
                Debug.Log("Loop i = "+i);
                Debug.Log(Time.deltaTime);
            }
        }

        if(Input.GetKeyDown(UnityEngine.KeyCode.UpArrow)){
            Debug.Log("Up arrow has been clicked");
        }

        if(Input.GetKey(UnityEngine.KeyCode.LeftArrow)){
            transform.Translate(Vector3.left*10f*Time.deltaTime);
        }

        if(Input.GetKey(UnityEngine.KeyCode.RightArrow)){
            transform.Translate(Vector3.right*10f*Time.deltaTime);
        }
        
    }
}
