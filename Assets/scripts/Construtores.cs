using UnityEngine;

public class Construtores : MonoBehaviour
{
    metodos obj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = new metodos (20, "OLÁ");

        Debug.Log(obj.v1);
        Debug.Log(obj.v2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
class metodos
{

    public int v1;
    public string v2;

    public metodos(int val1, string val2)
    {
        this.v1 = val1;
        this.v2 = val2;
    }

}
