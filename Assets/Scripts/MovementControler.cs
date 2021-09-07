using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementControler : MonoBehaviour
{
    private GaticoMoves gaticoMov;
    private InputAction movement;
    private Rigidbody2D plyr;

    public float Force = 5f;

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
        if (movement.ReadValue<Vector2>().x != 0)
            plyr.velocity = new Vector2(movement.ReadValue<Vector2>().x * (Force / 2), 0);
    }
}
