using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField] private GameObject[] sillas;

    // Start is called before the first frame update
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("SILLA");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            AgregarColliderAElementosDelArray();
            AgregarRBAElementosDelArray();
        }
    }

    void DesactivarElementosDelArray()
    {
        for(int i = 0; i < sillas.Length; i++)
        {
            sillas[i].SetActive(false);
        }
    }

    void AgregarRBAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            sillas[i].AddComponent<Rigidbody>();
        }
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            sillas[i].AddComponent<BoxCollider>();
        }
    }
}
