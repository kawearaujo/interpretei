using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atividades : MonoBehaviour
{
    public int setado;
    public List<GameObject> lista;
    public List<GameObject> imagemActive;
    public void Atividades (){
        if (PlayerPrefs.HasKey("atividades")){
            setado = PlayerPrefs.GetInt("atividades");
            if (setado==1){
                PlayerPrefs.SetInt("atividades",0);
                trocar(0);
            }
        }
    } 
    public void Conquistas (){
        if (PlayerPrefs.HasKey("atividades")){
            setado = PlayerPrefs.GetInt("atividades");
            if (setado==0){
                PlayerPrefs.SetInt("atividades",1);
                trocar(1);
            }
        }
    }

    void trocar (int value){
        for (int i = 0; i < lista.Count; i++){
            if (value==i){
                lista[i].SetActive(true);
                PlayerPrefs.SetInt("atividades",i);
                imagemActive[i].SetActive(false);
            }else{
                lista[i].SetActive(false);
                imagemActive[i].SetActive(true);
            }
        }
    }

    void Start()
    {
        PlayerPrefs.SetInt("atividades",0);
    }

}
