using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int Num1 = 0;
    int Num2 = 10000;
    int Num3 = 20;
    float Num4;

    void Impresion1erInt()
    {
        Num1 = Num1 + 2;
        Debug.Log(Num1);
    }

    void Impresion2doInt_UnParametro(int LocalNum2) 
    {
        Debug.Log("El valor Local Es: " + LocalNum2);
        Debug.Log("El Valor Global: " + Num2);
    }

    float DevolverSumaFloat_DosParametros(int Primero, float Segundo)
    {
        return Primero + Segundo;
    }

    void Start() 
    {
        //Impresion2doInt_UnParametro(5);
        Num4=DevolverSumaFloat_DosParametros(Num2, Num3);
        Debug.Log(Num4);
    }   

    void FixedUpdate()
    {
        //Impresion1erInt();.
        //Num2 = Num2 - 1;

    }


}
