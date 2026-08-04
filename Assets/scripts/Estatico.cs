using UnityEngine;

public class Estatico : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int retorno = estatico.soma(2,2);

        Debug.Log(retorno);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class estatico
{
    public static int soma (int v1, int v2)
    {
        int res = v1 + v2;

        return res;
    }
}
