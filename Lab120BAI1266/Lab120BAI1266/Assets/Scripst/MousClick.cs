using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MousClick : MonoBehaviour
{
    void OnMouseDown (){
        SceneManager.LoadScene("Lab6_S2");
    }   
}
