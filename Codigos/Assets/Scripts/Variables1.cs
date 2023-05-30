using System;
using UnityEngine;
using Debug = UnityEngine.Debug;




public class Variables1 : MonoBehaviour
{
    int Numero1 = 10;
    float Numero2 = 1.5f;
    int Numero3;

    float FN1, FN2;
    float FN3;
   
    float FN4;
    int FN5;

    string Numeros = "PAR, IMPAR";

    float Decimal = 90.123456789f;

    string Nombre = "Jonathan Ivan Gonzalez Villalobos";
    char Delimitador = ' ';
    char c = '1';

    string Valor1;
    float Valor2;
    string Valor3;
    int Valor4;
    



    void Start()
    {
        // summa entre 2 int
        FN1 = 10.5f;
        FN2 = 5.4f;
        FN3 = FN1 + FN2;
        //Debug.Log("la suma es:" + FN3);

        //casteo explicito 
        FN4 = FN3;
        FN5 = (int)FN4;
        //Debug.Log("resultado en numero entero es:" + FN5);

        // float de mas de 4 nums a maximo 4 nums
        String DecimalStr = Decimal.ToString("0.0000");
        //Debug.Log(Decimal.ToString("0.0000"));

        // se divide un string en 2 o mas con substring
        string PrimerNombre = Nombre.Substring(0, 13);
        string Apellidos = Nombre.Substring(13,20);
        //Debug.Log("Mi nombre es: " + PrimerNombre + " y mis apellidos son:" + Apellidos);

        // uso de split para poner los nombres en lista 
        string[] NombreCompleto = Nombre.Split(Delimitador);
        //Debug.Log(NombreCompleto[0] + NombreCompleto[1] + NombreCompleto[2] + NombreCompleto[3]);
        foreach (string str in NombreCompleto)
        {
            //Debug.Log(str);
        }

        // conversion de un string a float con TryParse
        Valor1 = "1687631891027";

        if (Single.TryParse(Valor1, out Valor2))
        {
            //Debug.Log(Valor2);
        }

        //conversion de un string a in t con int32.parse
        Valor3 = "+1000";
        try
        {
            int Valor5 = Convert.ToInt32(Valor3);   
            //Debug.Log($"si se pudo '{Valor5}'");
        }
        catch (FormatException)
        {
            //Debug.Log($"No se pudo XD'{Valor3}'");
        }

        //Impresion de los caracteres que equivalen a un numero par.
        string Frase = "Necesito ayuda con el codigo";
        string frasePar = "";
        for (int i = 0; i < Frase.Length; i++)
        {
            if (i % 2 == 0)
                frasePar = frasePar + Frase[i];
        }
        //Debug.Log(frasePar);

        // se eliminan los primieros caracteres o los primeros 5 caracteres de un string.
        string primeros5 = Frase.Remove(0, 5); 
        Debug.Log(primeros5);



    } 

    void Update()
    {
       //variable que incrementa su valor +5
       Numero1 += 5;
       //Debug.Log("el valor de Numero1 es:" + Numero1);
    }

    void FixedUpdate()
    {
         // numero float que incrementa su valor 1.5 y conversion a entero.
         Numero2 += 1.5f;
         //Debug.Log("el valor de Numero2 es:" + Numero2);
         Numero3 = (int)Numero2;
         //Debug.Log( "el valor de Numero2 en entero es:" + Numero3);

        // operacion para saber si un numero es par o impar y cambio de color en base al resultado.
        if (Numero3 % 2 == 0) 
        {
             GetComponent<MeshRenderer>().material.color = Color.green;
             //Debug.Log("PAR");
             Numeros = "PAR";
        }

        else 
        {
             
            GetComponent<MeshRenderer>().material.color = Color.blue;
            //Debug.Log("IMPAR");
            Numeros = "IMPAR";
        }

        // uso de Switch para evaluar el resultado con palabras y cambiar el cubo en base a la palabra mostrada.
        switch (Numeros)
        {
            case "PAR":
                //Debug.Log("Numero par");
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case "IMPAR":
                //Debug.Log("Numero impar");
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
        }

    }

}
