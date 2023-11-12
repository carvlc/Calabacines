using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private float speed;// variable que almacena la velocidad de movimiento 

    private void Start()
    {
        speed = 1f;// se inicia la valocidad de movimiento 
    }

    private void Update()
    {
        // se traslada la platafomra hacia abajo normalizada con deltatime
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        // si sobrepasa -5 en el eje Y se destruye la plataforma
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    // este metodo sirve para que el player se pare sobre la plataforma
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))// si el objeto que coliciona es el Player...
        {
            collision.gameObject.transform.SetParent(this.transform);// el player se asigna como hijo de la plataforma 
        }
    }

    // este metodo sirve para desvilcular al Player de la plataforma una vez que salta
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))// si al objeto que sale es el Player...
        {
            other.gameObject.transform.SetParent(null);// se asigna null, y el player deja de ser hijo de la plataforma
        }
    }
}
