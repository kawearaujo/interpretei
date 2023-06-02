using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Serializable]
public class player : MonoBehaviour
{
   public string Name;
   public string Avatar;
   public int Estrelas;
   public int SuperEstrelas;
   public int Moedas;
   public string DiasJogados;

//    private string path = "Assets/Player.txt";
   
   public void Save()
   {    
    var content = JsonUtility.ToJson(this,true);
    // System.File.WriteAllText(path, content);
    // Debug.log(path);
   }

}
