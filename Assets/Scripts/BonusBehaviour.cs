using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBehaviour : MonoBehaviour
{
    private float speed;// variable para asignar la velocidad de desplazamiento del diamante bonus
    [SerializeField] private AudioClip bonusSFX;// se crea una variable serializada para asignarle el sonido de bonus
    void Start()
    {
        speed = 1;// se inicializa la velocidad de despazamiento
    }

    void Update()
    {
        // se traslada el objeto bonus para abajo normalizado por deltatime
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        // si el objeto alcanza -5 en y se destruye
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
    // si el player colisiona con el bonus, se suma el puntaje y se elimina el objeto Bonus
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManagerBehaviour.Instance.PlaySound(bonusSFX);// se ejecuta el sonido del bonus
            Puntaje.Instance.SumarPuntaje();// metodo sumar puntaje
            Destroy(gameObject);// se destruye el gameobject Bonus
        }
    }
}
