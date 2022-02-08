using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharController : MonoBehaviour
{

    private PlayerActions playerInputActions;
    public InputAction movementAction;
    [SerializeField] private Rigidbody PlayerRigidBody;
    [SerializeField] private int Speed = 15;
    [SerializeField] private int JumpForce = 5;

    private void Awake() {
        playerInputActions = new PlayerActions();
        
        movementAction = playerInputActions.PlayerControls.Movement;
        
        playerInputActions.PlayerControls.Jump.performed += context => Jump();
    }

    private void OnEnable() { 
        playerInputActions.Enable();
    }

    private void OnDisable() {
        playerInputActions.Disable();
    }

    private void FixedUpdate() {
        Move(movementAction.ReadValue<Vector2>());
    }

    private void Move(Vector2 direction) {
        Vector3 moveVector = new Vector3(direction.x, 0f, 0f) * Speed;
        PlayerRigidBody.velocity = new Vector3(moveVector.x, PlayerRigidBody.velocity.y, PlayerRigidBody.velocity.z);
    }

    private void Jump() {
        // TODO: Add ground check to remove infinite jumping bug
        PlayerRigidBody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }
}
