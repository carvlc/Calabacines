using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject platform;//variable que almacena el prefab de plataforma
    private float randomPosition;// variable que almacena posicion
    private float randomTime;// variable que almacena el time
    private void Start()
    {
        StartCoroutine("GenerarNubes");// se inicia la corrutina GenerarNubes
    }

    // corrutina que genera nubes en posiciones aleatoria y tiepo aleatorio
    IEnumerator GenerarNubes()
    {
        randomPosition = Random.Range(-7, 7);// se asigna un valor aleatorio a posicion
        randomTime = Random.Range(0, 3);// se asigna un valor aleatorio a time
        // se instancia una plataforma en posicion X aleatoriamente
        Instantiate(platform, new Vector3(randomPosition, transform.position.y, transform.position.z), transform.rotation);
        yield return new WaitForSeconds(randomTime);// se espera un tiempo aleatorio
        StartCoroutine("GenerarNubes");// se vuelve a iniciar la corrutina
    }
}
