using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    private float speed;// variable para la velocidad de desplazamiento
    void Start()
    {
        speed = 1;// se inicializa la variable de velocidad de desplazamiento
    }

    void Update()
    {
        // se desplaza al objeto monster para abajo normalizado con deltatime
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        // si el monster es menor que -5 se destruye
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    // si el player colisiona con el mosnter se resta puntjae
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Puntaje.Instance.RestarPuntaje();// se llama a al metodo restarpuntaje
            Destroy(gameObject);// se destruye el objeto moster
        }
    }
}
