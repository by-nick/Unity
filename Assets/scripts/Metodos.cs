using UnityEngine;

public class Metodos : MonoBehaviour
{
    metodo somar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int val;
        somar = new metodo ();  
        val = somar.soma(10,2);


        Debug.Log(val);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class metodo
{
    public int soma(int v1, int v2)
    {
        int res = v1+v2;

        return res;
    }
}