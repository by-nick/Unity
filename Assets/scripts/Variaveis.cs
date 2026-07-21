using System;
using UnityEngine;

public class Variaveis : MonoBehaviour
{

    int moedas;
    string player;
    string classe;
    int idade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moedas = 10;
        player = "Nick";
        classe = "Bardo";
        idade = 35;

        Debug.Log ("Player: " + player + " Classe escolhida: " + classe + " Idade: " + idade + " QTD Moedas: " + moedas);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
