using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class ManagerUI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_usuario;
    // Start is called before the first frame update
    void Start()
    {
        string nom_usuario = PlayerPrefs.GetString("usuario","");
        Scene scene=SceneManager.GetActiveScene();

        if (scene.buildIndex == 2)
        {
            txt_usuario.text = nom_usuario;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            Scene scene;
            scene = SceneManager.GetActiveScene();
            if (scene.buildIndex == 3)
            {
                cargarEscena(2);
            }
        }
    }

    public void cargarEscena(int index)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 0)
        {
            string nom_usuario = txt_usuario.text;
            PlayerPrefs.SetString("usuario", nom_usuario);
        }
        SceneManager.LoadScene(index);
        /* index:
         * inicio 0
         * fin 2
         * juego 3
         */
    }
}
