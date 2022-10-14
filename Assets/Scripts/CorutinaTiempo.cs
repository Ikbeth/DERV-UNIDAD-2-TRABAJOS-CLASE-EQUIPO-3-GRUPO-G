using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CorutinaTiempo : MonoBehaviour
{
    TextMeshProUGUI t_tiempo;
    int tiempoInicio;
    private void Awake()
    {
        GameObject obj = GameObject.Find("txtTiempo");
        t_tiempo = obj.GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        tiempoInicio = 10;
        StopAllCoroutines();
        StartCoroutine("controlTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator controlTiempo()
    {
        while (tiempoInicio >= 0)
        {
            t_tiempo.text = tiempoInicio.ToString();
            tiempoInicio--;
            yield return new WaitForSeconds(.5f);

        }

    }
}
