using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed;// variable para la velocidad de movimiento
    private bool isFacingRight;// variable para controlar la orientacion del sprite del player
    private Rigidbody2D _rigidbody;// variable que almacena un rigidbody
    private float limitRangeX;// variable para control del limite en X

    private void Start()
    {
        movementSpeed = 5f;// se inicializa la velocidad de movimiento
        limitRangeX = 9f;// se asigna un valor al rango limite X
        isFacingRight = true;// se inicia la variable en true
        _rigidbody = GetComponent<Rigidbody2D>();// se obtiene el rigidbody del objeto player
    }

    private void Update()
    {
        float movementX = Input.GetAxis("Horizontal"); // se obtiene direccion del input de movimiento horiazontal
        Move(movementX * movementSpeed);//se llama al metodo move y se pasa por parametro la direccion por la velocidad
        // gira el player si se mueve a la izquierda
        if (movementX > 0 && isFacingRight)
        {
            Flip();
        }
        //gira el player si se mueve a la derecha
        if (movementX < 0 && !isFacingRight)
        {
            Flip();
        }
    }

    public void Move(float directionVelocity)
    {
        // control para que el player no se salga de la pantalla en los laterales
        if (gameObject.transform.position.x < -limitRangeX)// si la posicion x del player es menor al rango limite X negativo...
        {
            // el player no pasara del rango limite X negativo
            gameObject.transform.position = new Vector3(-limitRangeX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (transform.position.x > limitRangeX)// si la posicion x del player es mayor que el limite x...
        {
            // el player no pasara del rango limite X
            transform.position = new Vector3(limitRangeX, transform.position.y, transform.position.z);
        }
        else
        {
            // se mueve el player en la direccion pasada por parametro y normalizada con deltatime
            transform.Translate(Vector3.right * directionVelocity * Time.deltaTime);
        }
    }
    // metodo plip que voltea el sprite del player segun su direccion 
    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;// se actualiza isFacingRight por su valor opuesto
    }
}
