using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject monster;// esta bariable contendra al prefab de Monster
    private float randomPosition;// variable que almacena el valor random de posicion 
    private float randomTime;// variable que almacena el valor random de tiempo 
    private void Start()
    {
        StartCoroutine("GenerarMonster");// se inicia la corrutina GenerarMonster
    }
    // corrutina para generar monster aleatoriamente en un tiempo aleatorio
    IEnumerator GenerarMonster()
    {
        randomPosition = Random.Range(-7, 7);// se asigna un valor aleatorio a la variable posicion
        randomTime = Random.Range(3, 5);// se asigna un valor aleatorio a la variable time
        // se intancia un monster en una posicion aleatoria del eje X
        Instantiate(monster, new Vector3(randomPosition, transform.position.y, transform.position.z), transform.rotation);
        yield return new WaitForSeconds(randomTime);// se espera un tiempo aleatorio
        StartCoroutine("GenerarMonster");// se llama a la corrutina
    }
}
