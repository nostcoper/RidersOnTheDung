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

    void FixedUpdate()
    {
        rb.AddForce(_movementInput * speed, ForceMode.Impulse);
        RespondToRotationInput();
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _movementInput = value.ReadValue<Vector3>();
    }
    

    private void RespondToRotationInput()
    {

        if (Input.GetKey(KeyCode.J))
        {
            character.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            //characterAnimator.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            character.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);

            //characterAnimator.SetBool("isRunning", true);
        }
    }
}
