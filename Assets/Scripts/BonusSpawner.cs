using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bonus;// esta variable contendra un prefab bonus
    private float randomPosition;// variable para marcar la posicion donde se crearan los bonus
    private float randomTime;// variable que contendra el valor para el tiempo para la corrutina
    private void Start()
    {
        StartCoroutine("GenerarBonus");// se inicia la corrutina que llama al metodo GenerarBonus
    }
    // corrutina que genera los Bonus en posiciones aleatoria en tiempo aleatorio
    IEnumerator GenerarBonus()
    {
        randomPosition = Random.Range(-7, 7);// se asigna un valor aleatorio para posicion
        randomTime = Random.Range(1, 3);// se asigna un valor aleatorio para el timepo
        // se instancia un bonus en una posicion X aleatoria
        Instantiate(bonus, new Vector3(randomPosition, transform.position.y, transform.position.z), transform.rotation);
        yield return new WaitForSeconds(randomTime);// se espara un valor de tiempo aleatorio 
        StartCoroutine("GenerarBonus");// se vuelve a llamar a la corrutina
    }
}
