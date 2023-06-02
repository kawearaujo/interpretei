using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marcado : MonoBehaviour
{
    public void resposta1(){
        PlayerPrefs.SetInt("resposta",0);
        Debug.Log(0);
    }
    public void resposta2(){
        PlayerPrefs.SetInt("resposta",1);
        Debug.Log(1);
    }
    public void resposta3(){
        PlayerPrefs.SetInt("resposta",2);
        Debug.Log(2);
    }
    public void resposta4(){
        PlayerPrefs.SetInt("resposta",3);
        Debug.Log(3);
    }


}
