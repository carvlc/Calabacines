using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalabazasBehaviour : MonoBehaviour
{
    // si el player se para en el suelo de calabazas se llama a la corrutina que resta puntaje cada segundo
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("DescontarPuntaje");// se inicia la corrutina
        }
    }
    // si el player avandona el suelo de calabazas se detiene la corrutina que resta puntaje cada segundo
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StopCoroutine("DescontarPuntaje");// se detiene la corrutina
        }
    }
    // corrutina para restar el puntaje cada segundo
    IEnumerator DescontarPuntaje()
    {
        Puntaje.Instance.RestarPuntaje();// se llama al metodo restarpuntaje
        yield return new WaitForSeconds(1);// se espera un segundo
        StartCoroutine("DescontarPuntaje");// se vuelve a llamar a la corrutina
    }
}
