using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string sabores;
    public float gramos;
    float precio = 0.5f;
    float precioFinal = 0;
    // Start is called before the first frame update
    void Start()
    {
        precioFinal = gramos * precio;

        if (sabores == "CHO" || sabores == "FRU" || sabores == "DDL")
        {
            if (gramos > 250 && gramos < 3000)
            {
                if (sabores == "FRU")
                {
                Debug.Log("El costo del pedido es $" + precioFinal * 9 / 10);

                } else
                Debug.Log("El costo del pedido es $" + precioFinal);
            }
            else
            {
                Debug.Log("error");
                return;
            }
        }
        else
        {
            Debug.Log("error");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
