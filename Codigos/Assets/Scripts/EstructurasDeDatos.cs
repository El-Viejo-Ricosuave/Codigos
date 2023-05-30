using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{

    List<int> Numbers = new List<int>();

    void Metodo1(int Tam, int Range1, int Range2) 
    {
        for (int i = 0; i < Tam; i++)
        {
            Numbers.Add(Random.Range(Range1, Range2));
        }
        foreach (int i in Numbers)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {
        Metodo1(30, 50, 100);
       

    }

    void Update()
    {
        
    }
}
