using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementControler : MonoBehaviour
{
    private GaticoMoves gaticoMov;
    private InputAction movement;
    private Rigidbody2D plyr;

    public float Force = 15f;

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
        var direction = movement.ReadValue<Vector2>().x;
        if (direction != 0)
            plyr.AddForce(new Vector2(direction * Force, 0f));
    }
}
