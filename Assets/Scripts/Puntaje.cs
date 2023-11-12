using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
   public static Puntaje Instance;
    private float puntajeActual;
    private Text texto;

    public Text Texto { get => texto; set => texto = value; }

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
        puntajeActual = 0f;
        Texto = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        // puntajeActual -= Time.deltaTime;
        Texto.text = "Puntaje: "+puntajeActual.ToString("0");
    }

    public void SumarPuntaje()
    {
        puntajeActual += 1f;
    }

    public void RestarPuntaje(){
            puntajeActual -= 1f;
    }
}
