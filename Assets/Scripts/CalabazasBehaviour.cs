using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalabazasBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("DescontarPuntaje");
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            StopCoroutine("DescontarPuntaje");
        }
    }

    IEnumerator DescontarPuntaje()
    {
        Puntaje.Instance.RestarPuntaje();
        yield return new WaitForSeconds(1);
        StartCoroutine("DescontarPuntaje");
    }
}
