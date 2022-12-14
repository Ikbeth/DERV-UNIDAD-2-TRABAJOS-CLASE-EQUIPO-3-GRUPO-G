using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeteccionColisiones : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_vida_desde_enemigo;
    [SerializeField]
    TextMeshProUGUI txt_ataque_desde_enemigo;

    // Start is called before the first frame update
    void Start()
    {
        int v = Singleton_Usuario.instancia.vida;
        int a = Singleton_Usuario.instancia.ataque;

        txt_vida_desde_enemigo.text = v.ToString();
        txt_ataque_desde_enemigo.text = a.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Nombre: " + name + " Tag: " + tag);
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
}
