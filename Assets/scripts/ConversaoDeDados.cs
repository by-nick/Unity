using UnityEngine;
using System; 

public class ConversaoDeDados : MonoBehaviour
{

    int carteira = 100;
    float carteira2 = 10.5f;
    bool teste = true;
    string texto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        texto = carteira.ToString();
        Debug.Log(carteira);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
