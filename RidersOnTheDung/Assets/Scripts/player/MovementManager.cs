using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [Header("Configuration")]
    public float speed;
    public float rotationSpeed;
    public GameObject dung;
    public GameObject character;
    public GameObject mainCamera;
    //public Animator characterAnimator;

    [Header("Dependencies")]
    public Rigidbody rb;
    private GameObject characterModel;

    private Vector3 _movementInput;
    private PlayerInput playerInput;

   void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }
    void FixedUpdate()
    {
        
        RespondToMovementInput();
        RespondToRotationInput();
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _movementInput = value.ReadValue<Vector3>();
    }
    private void RespondToMovementInput(){
        Vector3 movement = new Vector3(_movementInput.x, 0, _movementInput.z);
        Vector3 forwardMovement = mainCamera.transform.forward * movement.z;
        Vector3 rightMovement = mainCamera.transform.right * movement.x;
        rb.AddForce((forwardMovement + rightMovement) * speed , ForceMode.Impulse);
    }   

    private void RespondToRotationInput()
    {
        float turnInput = playerInput.actions["Camera"].ReadValue<float>();

         if (turnInput < 0)
        {
            character.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            //characterAnimator.SetBool("isRunning", true);
        }
        else if (turnInput > 0)
        {
            character.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);

            //characterAnimator.SetBool("isRunning", true);
        }
    }
}
