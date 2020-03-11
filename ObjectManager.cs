using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [Header("Seleccionar cantidad de grupos de objetos:")]
    [Header("Código por Cristian Cázares")]
    [Tooltip("Aquí se deben de seleccionar qué tantos elementos se estarán mostrando." +
        "\n\nAl darle un valor a \"size\", aparecerá una lista de elementos esperando a ser instnaciados.")]
    public GameObject[] objects;

    GameObject current;
    int len;
    int taps;
    // Start is called before the first frame update
    void Start()
    {
        len = objects.Length;
        taps = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (taps < len-1)
            {
                taps++;
            }
            else
            {
                taps = 0;
            }

        }

        if (len > 0)
        {
            if (taps !=len)
            {
            objects[taps].SetActive(true); //Activar objeto actual
            }
            for (int i = 0; i < len; i++) //Desactivar todos...
            {
                if (i != taps) //...excepto el actual
                {
                    objects[i].SetActive(false);
                }
            }
        }
        else
        {
            Debug.LogError("Para el indexador de objetos funcione, se necesita un valor mayor a cero.\nAtte. Cristian Cázares.");
        }
    }

}
