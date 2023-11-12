using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;// fuerza del salto
    private bool isGrounded;// bandera para verificar si esta tocando plataforma
    private Rigidbody2D _rigidbody;// variable para almacenar el rigidbody

    private void Start()
    {
        jumpForce = 13f;// inicializamos la fuerza de salto
        _rigidbody = GetComponent<Rigidbody2D>();// se obtiene el rigidbody del player
    }

    private void Update()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))// si isGrounded es verdadera y  se preciona la tecla Space, el player puede saltar
        {
            Jump();// se llama a la funcion de salto
        }
    }
    // cuando el player esta sobre una plataforma, se actualiza la variable isGrounded en true
    private void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
    }

    // cuando el player no este sobre una plataforma se actualiza la variable isGrounded en false
    private void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }

    // metodo salto
    public void Jump()
    {
        _rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);// se aplixa la fuerza de salto al rigidbody del player
    }
}
