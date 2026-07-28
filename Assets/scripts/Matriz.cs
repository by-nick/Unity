using UnityEngine;

public class Matriz : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int [,] matriz = new int[2,2];
        int valor = 1;

        for (int linha = 0; linha <= 1; linha++)
        {
            for (int coluna = 0; coluna <= 1; coluna++)
            {
                matriz [linha,coluna] = valor;
                valor++;
            }
        }

        for (int linha = 0; linha <= 1; linha++)
        {
            for (int coluna = 0; coluna <= 1; coluna++)
            {
                Debug.Log(linha + " : " + coluna +" = " + matriz[linha,coluna]);
            }
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
