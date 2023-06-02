using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AtualizaNome : MonoBehaviour
{
    public TextMeshProUGUI textoTMP;
    // Start is called before the first frame update
    void Start()
    {   
        if(PlayerPrefs.HasKey("nome"))
            textoTMP.text = PlayerPrefs.GetString("nome");
        else
            textoTMP.text = "Psyduck";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
