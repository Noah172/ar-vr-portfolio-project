using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementControler : MonoBehaviour
{
    private GaticoMoves gaticoMov;
    private InputAction movement;
    private Rigidbody2D plyr;
    private float Gravity = 3f;

    public float Force = 7f;

    private void Awake()
    {
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
        plyr.velocity = new Vector2(plyr.velocity.x, Force);
    }

    private void OnDisable()
    {
        movement.Disable();
        gaticoMov.Maww.Jump.Disable();
    }

    private void FixedUpdate()
    {
        plyr.velocity = new Vector2(0, Gravity * -1);
        if (movement.ReadValue<Vector2>().x != 0)
            plyr.velocity = new Vector2(movement.ReadValue<Vector2>().x * (Force / 2), 0);
    }
}
