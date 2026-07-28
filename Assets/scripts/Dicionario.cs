using System.Collections.Generic;
using UnityEngine;

public class Dicionario : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Dictionary<string,string> vilao = new Dictionary<string, string> ();

        vilao.Add("Zumbi de Fogo", "Primeiro vilão");
        vilao.Add("Zumbi Estalador", "Baseado em The last of us");
        vilao.Add("Zumbi Emmilly", "Baseado em RE9");

        foreach(string chave in vilao.Keys)
        {
            foreach (string valor in vilao.Values)
            {
                Debug.Log(chave + ":" + valor);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
