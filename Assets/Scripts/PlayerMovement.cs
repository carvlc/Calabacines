using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed;
    private bool isFacingRight;
    private Rigidbody2D _rigidbody;
    private float limitRangeX;

    private void Start()
    {
        movementSpeed = 5f;
        limitRangeX = 9f;
        isFacingRight = true;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        Move(movementX * movementSpeed);
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

    public void Move(float velocity)
    {
        // control para que el player no se salga de la pantalla en los laterales
        if (gameObject.transform.position.x < -limitRangeX)
        {
            gameObject.transform.position = new Vector3(-limitRangeX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (transform.position.x > limitRangeX)
        {
            transform.position = new Vector3(limitRangeX, transform.position.y, transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.right * velocity * Time.deltaTime);
        }
    }
    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
    }
}
