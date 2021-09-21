using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementControler : MonoBehaviour
{
    private GaticoMoves gaticoMov;
    private InputAction movement;
    private Rigidbody2D plyr;
    private bool IsGrounded;

    public float Force = 8.7f;
    public int Health = 100;

    private void Awake()
    {
        IsGrounded = true;
        gaticoMov = new GaticoMoves();
        plyr = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        movement = gaticoMov.Maww.Movement;
        movement.Enable();

        gaticoMov.Maww.Jump.performed += jump;
        gaticoMov.Maww.Enable();
    }

    private void jump(InputAction.CallbackContext obj)
    {
        if (IsGrounded)
        {
            plyr.velocity = new Vector2(plyr.velocity.x, Force);
            IsGrounded = false;
        }
            
    }

    private void OnDisable()
    {
        movement.Disable();
        gaticoMov.Maww.Jump.Disable();
    }

    private void FixedUpdate()
    {
        var direction = movement.ReadValue<Vector2>().x;
        if (direction != 0)
            plyr.AddForce(new Vector2(direction * Force, 0f));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor" && IsGrounded == false)
        {
            IsGrounded = true;
        }

        if (other.gameObject.tag == "Enemy")
        {
            Health -= 15;
        }

        if (other.gameObject.tag == "Bullet")
        {
            Health -= 35;
        }
    }
}
