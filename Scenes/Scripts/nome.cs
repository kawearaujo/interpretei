using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class nome : MonoBehaviour
{

    [SerializeField] private string inputText;
    public TextMeshProUGUI textoTMP;
    public string nomePessoa;


    public void InputField(string input){
        inputText = input;
        PlayerPrefs.SetString("nome",input);
        Debug.Log(input);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        // nomePessoa = nomeString[0];
        // PlayerPrefs.SetInt("nome","")
    }

     public void AtualizarNome()
    {
        // SetNome();
        
    }

    public void SetNome(string text)
    {
        PlayerPrefs.SetString("nome",text);
    }

    public void GetNome()
    {
        PlayerPrefs.GetString("nome");
    }


    void Update()
    {
        // AtualizarNome();
        // Debug.Log(textoTMP.text);
    }
}
