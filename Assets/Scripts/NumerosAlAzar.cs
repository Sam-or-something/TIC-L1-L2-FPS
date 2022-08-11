using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosAlAzar : MonoBehaviour
{
    [SerializeField] private int random_number;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GenerarNumeroAleatorio();
        }
    }

    void GenerarNumeroAleatorio()
    {
        random_number = Random.Range(0, 4);
    }
}
