using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.Quest.Alpha.Phases.Games
{
[RequireComponent(typeof(CharacterController))]
public class RobotController : MonoBehaviour
{
    [Header("Controller Settings")]
    private CharacterController charControl;
    [SerializeField] private float moveSpeed = 15f;
    [SerializeField] private float jumpHeight = 2f;
    [SerializeField] private float gravity = -9.81f; // Custom gravity scale
    [SerializeField] private LayerMask groundMask; // To define what layers count as ground
    [SerializeField] private Transform groundCheck; // Empty GameObject at the feet to check if grounded
    private Vector3 v_movement;
    private Vector3 v_velocity; // Handles vertical velocity
    private bool isGrounded; // Is the robot on the ground?
    private float groundDistance = 0.4f; // Distance for ground check
        public bool isCharActive;
    private float inputX;
    private float inputZ;
        public Animator swing;
    public Camera mainCam; // Reference to the camera
    public LayerMask ignoreMe;
    public AudioSource jump;
    private void Awake()
    {
        charControl = GetComponent<CharacterController>();
      
    }

    void Update()
    {
            if (isCharActive)
            {
                HandleMovementInput();
                HandleJumpAndGravity();

                if (Input.GetMouseButtonDown(0) || (Input.GetKeyDown(KeyCode.E)))
                {
                    swing.SetTrigger("swing");
                }
            }
       
      //  HandleMouseRaycast();
    }

    private void HandleMovementInput()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        // Basic movement on the forward axis
        v_movement = charControl.transform.forward * inputZ;

        // Rotate based on horizontal input (A/D or Left/Right arrows)
        charControl.transform.Rotate(Vector3.up * inputX * (100f * Time.deltaTime));

        // Apply the movement
        charControl.Move(v_movement * moveSpeed * Time.deltaTime);
    }

    private void HandleJumpAndGravity()
    {
        // Ground check: Sphere check at the robot's feet
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // Reset downward velocity if grounded
        if (isGrounded && v_velocity.y < 0)
        {
            v_velocity.y = -2f; // Small negative value to keep grounded
        }

        // Jump logic: If the player is grounded and presses the jump button
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            v_velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                jump.Play();
        }

        // Apply gravity
        v_velocity.y += gravity * Time.deltaTime;

        // Apply vertical velocity
        charControl.Move(v_velocity * Time.deltaTime);
    }
  
    }
}

