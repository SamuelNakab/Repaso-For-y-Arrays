using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    public int numInicio;
    public int numFin;
    // Start is called before the first frame update
    void Start()
    {
        //enteros mults de 3 [6 ; 30]
        for(int i = 6; i <= 30; i+=3)
        {
            Debug.Log(i);
        }
        //enteros 0 a 50 excepto multiplos de 7
        for(int j = 0; j <= 50; j++)
        {
            if (j % 7 != 0)
            {
                Debug.Log(j);
            }
        }

        //escribir los int entre dos nums ingresados  sin incluirlos
        for(int i = numInicio +1; i < numFin; i++)
        {
            Debug.Log(i);
        }

        //int entre 100 - 0 descendente
        for(int i = 100; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
