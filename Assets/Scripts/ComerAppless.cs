using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComerAppless : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

        if (tag.Equals("GameController"))
        {
            GameObject obj = GameObject.Find(name);
            Destroy(obj);
        }


    }
}
