using UnityEngine;
using System.Collections.Generic;

public class Listas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> lista = new List<int> ();

        lista.Add(100);
        lista.Add(200);
        lista.Add(400);
        lista.Add(500);

        lista.Remove(200);
        Debug.Log(lista[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
