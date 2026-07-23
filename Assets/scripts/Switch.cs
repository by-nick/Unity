using UnityEngine;

public class Switch : MonoBehaviour
{

    int estados = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //switch para inimigo
        switch (estados)
        {
            case 1:
                Debug.Log("Mate o Jogador");
                break;

            case 2:
                Debug.Log("Mate se puder");
                break;

            case 3:
                Debug.Log("Corra agora");
                break;
            default:
                Debug.Log("Nenhum estado selecionado");
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
