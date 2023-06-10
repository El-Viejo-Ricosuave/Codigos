using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> Numbers = new List<int>();
    int[] Values = { 25, 3, 7, 55, 78, 65, 24, 44, 58, 63 };
    List<string> Names = new List<string>();
    Stack  <string> Magazine = new Stack<string> ();
    Queue<string> Shells = new Queue<string> ();


    void Ammo() 
    {
        Magazine.Push("5.56");
        Magazine.Push("7.62");
        Magazine.Push(".38 SPL");
        Magazine.Push(".22 LR");
        Magazine.Push("380 ACP");
        Magazine.Push("44 MAG");
        Magazine.Push("5.7 FN");
        Magazine.Push("9mm");
        Magazine.Push(".50");
        Magazine.Push(".12GA");

        //Debug.Log(Magazine.Peek());
        //Magazine.Pop();
        //Debug.Log(Magazine.Peek());
        //Magazine.Pop();
        //Debug.Log(Magazine.Peek());
        //Magazine.Pop();

        foreach( var Bullets in  Magazine ) 
        {
            Debug.Log(Bullets);

        }
        foreach (var Bullets in Magazine) 
        {
            Shells.Enqueue(Bullets);
        }

        Shells.Dequeue();
        Shells.Dequeue();
        Shells.Dequeue();
        Shells.Dequeue();
        Shells.Dequeue();

        foreach (var shots in Shells) 
        {
            Debug.Log(shots +"\n");
        }

    }

    void  GreekNames() 
    {
        Names.Add("Sofistas");
        Names.Add("Leonidas");
        Names.Add("Anaximandro");
        Names.Add("Diogenes");
        Names.Add("Aquiles");
        Names.Add("Hephestos");
        Names.Add("Herodotos");
        Names.Add("Leonidas");
        Names.Add("Anaximandro");
        Names.Add("Diogenes");
        Names.Add("Aquiles");
        Names.Add("Pelopidas");
        Names.Add("Hephestos");
        Names.Add("Gaia");
        Names.Add("Adastro");

        HashSet<string> hashWithoutDuplicates = new HashSet<string>(Names);

        foreach (var Nombres in hashWithoutDuplicates) 
        {
            Debug.Log(Nombres);
        }

    }

    int[] Sortedvalues(int[] TopToBottom)
    {
        for (int i = 0; i < TopToBottom.Length; i++)
        {
            Array.Sort(TopToBottom);
            Array.Reverse(TopToBottom);
            Debug.Log(TopToBottom[i]);
        }
        return TopToBottom;
    }

    void Metodo1(int Size, int Range1, int Range2) 
    {   
        for (int i = 0; i < Size; i++)
        {
            Numbers.Add(UnityEngine.Random.Range(Range1, Range2));
        }
        foreach (int i in Numbers)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {
        //Metodo1(30, 50, 100);
        //Sortedvalues(Values);
        //GreekNames();
        Ammo();

    }

    void Update()
    {
        
    }
}
