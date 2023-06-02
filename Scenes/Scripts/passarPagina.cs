using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Pagina.;
public class passarPagina : MonoBehaviour
{
    // public GameObject pagina;
    public List<GameObject> lista;
    public int paginaAtual;
    public int numeroTotalDePaginas;
    // public GameObject contadorDePagina;
    void Start()
    {
        paginaAtual= 0;
        PlayerPrefs.SetInt("paginaAtual", paginaAtual);
        PlayerPrefs.Save();
        // print(PlayerPrefs.GetInt("paginaAtual"));
        numeroTotalDePaginas = 3;
    }
    
    public void ProximaPagina()
    {
        // Verifique se há uma próxima página disponível
        paginaAtual = PlayerPrefs.GetInt("paginaAtual");
        if (paginaAtual < numeroTotalDePaginas -1)
        {
            paginaAtual++;
            // Atualize o conteúdo da página
            PlayerPrefs.SetInt("paginaAtual", paginaAtual);
            PlayerPrefs.Save();
            AtualizarConteudoDaPagina();
        }
        print(PlayerPrefs.GetInt("paginaAtual"));
    }
    public void PaginaAnterior()
    {
        // Verifique se há uma página anterior disponível
        paginaAtual = PlayerPrefs.GetInt("paginaAtual");
        if (paginaAtual > 0)
        {
            paginaAtual--;
            PlayerPrefs.SetInt("paginaAtual", paginaAtual);
            PlayerPrefs.Save();
            // Atualize o conteúdo da página
            AtualizarConteudoDaPagina();
        }
        print(PlayerPrefs.GetInt("paginaAtual"));
    }

    public void AtualizarConteudoDaPagina()
    {
        paginaAtual = PlayerPrefs.GetInt("paginaAtual");
        for (int i = 0; i < lista.Count; i++)
        {
            if (i == paginaAtual)
            {
                lista[i].SetActive(true);  // Objeto visível na página atual
            }
            else
            {
                lista[i].SetActive(false); // Objeto oculto nas outras páginas
            }
        }
    }
    

}
