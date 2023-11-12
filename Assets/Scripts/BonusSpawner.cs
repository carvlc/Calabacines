using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bonus;
    private float randomPosition;
    private float randomTime;
    private void Start()
    {
        StartCoroutine("GenerarBonus");
    }

    IEnumerator GenerarBonus()
    {
        randomPosition = Random.Range(-7, 7);
        randomTime = Random.Range(1, 3);
        Debug.Log(randomTime);
        Instantiate(bonus, new Vector3(randomPosition, transform.position.y, transform.position.z), transform.rotation);
        yield return new WaitForSeconds(randomTime);
        StartCoroutine("GenerarBonus");
    }
}
