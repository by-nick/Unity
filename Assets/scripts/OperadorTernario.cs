using UnityEngine;

public class OperadorTernario : MonoBehaviour
{

    float moedasPlayer = 50.4f;
    float valorPocaoVida = 100.4f;
    string res;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        res = (moedasPlayer >= valorPocaoVida)?"Poção de cura adquirida":"Poção não pôde ser comprada, valor insuficiente"; 
        Debug.Log(res);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
