using UnityEngine;

public class Foreach : MonoBehaviour
{
    string[] inimigos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inimigos = new string[4];
        inimigos[0] = "Caveira";
        inimigos[1] = "Matador";
        inimigos[2] = "Atirador";
        inimigos[3] = "Mark";

        foreach (string nome in inimigos)
        {
            Debug.Log(nome);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
