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
        }

        // Apply gravity
        v_velocity.y += gravity * Time.deltaTime;

        // Apply vertical velocity
        charControl.Move(v_velocity * Time.deltaTime);
    }
        /*
            private void HandleMouseRaycast()
            {

                    if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                {
                    Ray cameraRay = mainCam.ScreenPointToRay(Input.mousePosition); // Cast a ray from the camera
                    RaycastHit hitInfo; // Store hit info

                    if (Physics.Raycast(cameraRay, out hitInfo, 100f, ~ignoreMe))
                    {
                        Debug.Log("We Hit: " + hitInfo.collider.name); // Log the hit object
                    }
                }
            }

            private void OnDrawGizmosSelected()
            {
                // Visualize the ground check in the Scene view
                if (groundCheck != null)
                {
                    Gizmos.color = Color.red;
                    Gizmos.DrawWireSphere(groundCheck.position, groundDistance);
                }
            }
        */
    }
}

