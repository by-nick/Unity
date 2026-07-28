using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int[] array = { 1, 2, 3, 4, 5 };

        //int[] array = new int[4]{4,3,2,1};

        int [] array = new int [10];

        for (int i = 0; i <= 9; i++)
        {
            array[i] = i+1;
            Debug.Log(array[0]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
