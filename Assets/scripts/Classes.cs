using UnityEngine;

public class Classes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Felino gatoF1;
    
    void Start()
    {
        gatoF1 = new Felino ();

        gatoF1.nome = "Kitty";
        gatoF1.atacar ();
        gatoF1.corPelo = "Preto";
        gatoF1.forca = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class Felino
{
    //Caracteristicas = atributos
    public string nome;
    public string corPelo;
    public int forca;


    //acões = metodos
    public void atacar()
    {



    }
}
