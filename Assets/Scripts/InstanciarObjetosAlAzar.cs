using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarObjetosAlAzar : MonoBehaviour
{
    [SerializeField] private GameObject[] objetos_a_instanciar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InstanciarObjeto(objetos_a_instanciar[Random.Range(0, objetos_a_instanciar.Length)]);
        }
    }

    void InstanciarObjeto(GameObject objeto)
    {
        Instantiate(objeto, transform.position, transform.rotation);
    }
}
