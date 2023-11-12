using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public static Puntaje Instance;
    private float puntajeActual;
    private Text texto;

    [Header("Panels")]
    public GameObject gameover;// gameobject para el panel de gameover
    public Text Texto { get => texto; set => texto = value; }//propiedad de texto

    //singleton para trabajar con el puntaje
    private void Awake()
    {
        if (Puntaje.Instance == null)
        {
            Puntaje.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        puntajeActual = 0f;// inicializacion del puntaje
        Texto = GetComponentInChildren<Text>();//se obtiene el componente Text hijo
    }

    private void Update()
    {
        //se actualiza el puntaje en la pantalla
        Texto.text = "Puntaje: " + puntajeActual.ToString("0");
        //si el puntaje es menor que 0 se muestra la pantalla de gameover
        if (puntajeActual < 0)
        {
            gameover.SetActive(true);// se muestra el panel gameover
        }
    }
    // metodo para sumar puntaje
    public void SumarPuntaje()
    {
        puntajeActual += 1f;
    }
    //metodo para restar puntaje
    public void RestarPuntaje()
    {
        puntajeActual -= 1f;
    }
}
