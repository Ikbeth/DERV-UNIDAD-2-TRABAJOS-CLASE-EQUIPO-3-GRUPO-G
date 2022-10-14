using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_Usuario : MonoBehaviour
{
    public static Singleton_Usuario instancia;
    public int vida=100;
    public int ataque=50;

    private void Awake()
    {
        if (instancia == null)
        {
            ataque = 50;
            vida = 100;

            instancia = this;

        }
        else //Ya tenemos una instancia
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
