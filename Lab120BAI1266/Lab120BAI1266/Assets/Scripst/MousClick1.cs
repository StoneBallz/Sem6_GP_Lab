using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MousClick1 : MonoBehaviour
{
    void OnMouseDown (){
        SceneManager.LoadScene("Mouse_Button_Down");
    }   
}
