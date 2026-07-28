using UnityEngine;

public class Enum : MonoBehaviour
{
    enum Ai { Atacar, Correr, Patrulhar }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ai vilao01 = Ai.Patrulhar;
        Ai vilao02 = Ai.Atacar;
        Ai vilao03 = Ai.Correr;

        Debug.Log(vilao02);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
