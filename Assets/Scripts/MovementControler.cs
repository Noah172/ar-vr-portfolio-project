using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementControler : MonoBehaviour
{
    private GaticoMoves gaticoMov;
    private InputAction movement;

    private void Awake()
    {
        gaticoMov = new GaticoMoves();
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
        Debug.Log("Salto, saltito, saltote");
    }

    private void OnDisable()
    {
        movement.Disable();
        gaticoMov.Maww.Jump.Disable();
    }

    private void FixedUpdate()
    {
        // Debug.Log("moviendote " + movement.ReadValue<Vector2>());
    }
}
