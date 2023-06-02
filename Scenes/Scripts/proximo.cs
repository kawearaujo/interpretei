using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proximo : MonoBehaviour
{
    public string proximaPagina; // Nome da cena para a próxima página
    // public Player player;
    public void IrParaProximaPagina()
    {
        
        Debug.Log(proximaPagina);
        SceneManager.LoadScene(proximaPagina); // Carrega a próxima cena
    }
}
