using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    private float randomPosition;
    private float randomTime;
    private void Start()
    {
        StartCoroutine("GenerarNubes");
    }

    IEnumerator GenerarNubes()
    {
        randomPosition = Random.Range(-7,7) ;
        randomTime = Random.Range(0,3);
        Debug.Log(randomTime);
        Instantiate(platform,new Vector3(randomPosition, transform.position.y, transform.position.z),transform.rotation);
        yield return new WaitForSeconds(randomTime);
        StartCoroutine("GenerarNubes");
    }
}
