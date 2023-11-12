using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;// fuerza del salto
    private bool isGrounded;// bandera para verificar si esta tocando plataforma
    private Rigidbody2D _rigidbody;

    private void Start() {
        jumpForce = 15f;// inicializamos la fuerza de salto
        _rigidbody = GetComponent<Rigidbody2D>();// se obtiene el rigidbody del player
        _rigidbody.gravityScale = 0;
        Invoke("ActivarGravedad",5);
    }

    private void Update() {
        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other) {
        isGrounded = false;
    }

    public void Jump(){
        _rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    public void ActivarGravedad()
    {
        _rigidbody.gravityScale = 3;
    }
}
