using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptNumeroPagina : MonoBehaviour
{
    public  int nPagina;
    public TextMeshProUGUI textoTMP;
    // Start is called before the first frame update
    void Start()
    {
        nPagina = PlayerPrefs.GetInt("paginaAtual");
        // nPagina = Static.nPagina;
    }

    public void AtualizarPagina()
    {
        nPagina = PlayerPrefs.GetInt("paginaAtual");
        if (nPagina == 0){
            SetText("1/3");
        }else if (nPagina == 1){
            SetText("2/3");
        }else if (nPagina == 2){
            SetText("3/3");
        }
    }
    public void SetText(string text){
        textoTMP.text = text;
    }
    // Update is called once per frame
    void Update()
    {
        AtualizarPagina();
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class ScriptNumeroPagina : MonoBehaviour
// {
//     public  int nPagina;
//     public TMP_Text TextoTMP;
//     // public TextMeshProUGUI textoTMP;
//     // Start is called before the first frame update
//     void Start()
//     {
//         nPagina = 0;
//     }

//     public void AtualizarPagina() 
//     {
//         nPagina = Static.nPagina;
        
//         if (nPagina == 0){
//             textoTMP.text = "1/3";
//         }else if (nPagina == 1){
//             textoTMP.text = "2/3";
//         }else if (nPagina == 2){
//             textoTMP.text = "3/3";
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         AtualizarPagina();
//     }
// }
