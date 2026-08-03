using UnityEngine;

public class Classes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Felino gatoF1;
    
    void Start()
    {
        gatoF1 = new Felino ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class Felino
{
    //Caracteristicas = atributos
    string nome;
    string corPelo;
    int forca;


    //acões = metodos
    void atacar()
    {



    }
}
