using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submit : MonoBehaviour
{
    int reposta;
    public void Submit(){
        if(PlayerPrefs.HasKey("resposta")){
            reposta = PlayerPrefs.GetInt("resposta")+1;
            Debug.Log("enviar resposta "+reposta);
        }else{
            Debug.Log("não tinha resposta marcada");
        }

        
    }
}
