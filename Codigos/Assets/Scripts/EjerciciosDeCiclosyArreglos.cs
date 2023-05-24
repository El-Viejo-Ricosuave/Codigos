using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeCiclosyArreglos : MonoBehaviour
{
    int[] A = new int[6] { 8, 2, 5, 6, 3, 4 };
    int[] B = new int[6] { 9, 8, 7, 6, 5, 4 };
    int[] C = new int[6];

    string[] E = new string[4] { "Asi", "pasa", "cuando", "sucede" };
    string[] F = new string[4];

    int[,] G = new int[2, 3] { { 1, 10, 11 }, { 5, 2, 1 } };
    int[] H = new int [3] { 8, 6, 9 };
    int[,] I = new int[3, 3];



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            A[i] = Random.Range(0,101);
            //Debug.Log(A[i]);

        }
        for (int i = 0; i < 6; i++)
        {
            B[i] = Random.Range(101, 1001);
            //Debug.Log(B[i]);

        }
        for (int i = 0;i < 6; i++) 
        {
            C[i] = A[i] + B[i];
            //Debug.Log(C[i]);
        }

        foreach (string i in E)
        {
            F[0] = string.Join(" ", E);
            //Debug.Log(F[0]);
          
        }
        for (int X=0; X < 2; X++)
        {
            for (int Y = 0; Y < 3; Y++)
            {
                I[X,Y] += G[X, Y] * H[Y];

                Debug.Log(I[X,Y]);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
