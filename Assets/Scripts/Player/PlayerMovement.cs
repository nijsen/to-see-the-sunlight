using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement Settings")]
        [SerializeField] private float walkSpeed = 5f;
        [SerializeField] private float sprintSpeed = 12f; // Updated explicitly to 12 per your request

        [Header("Jump Settings")]
        [SerializeField] private float jumpForce = 12f;
        [SerializeField] private Transform groundCheckPoint;
        [SerializeField] private float groundCheckRadius = 0.2f;
        [SerializeField] private LayerMask groundLayer;

        [Header("Sprint 2 Sprite Verification Assets")]
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Sprite standSprite; // char_stand
        [SerializeField] private Sprite runSprite;   // char_run
        [SerializeField] private Sprite jumpSprite;  // char_jump

        private Rigidbody2D rb;
        private float horizontalInput;
        private bool isGrounded;
        private bool isSprinting;

        // Double Jump Tracking Variables
        private int jumpCount;
        private const int maxJumps = 2;

        public bool IsFacingRight { get; private set; } = true;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();

            // Auto-fallback: Locates child graphics components if unassigned
            if (spriteRenderer == null)
            {
                spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            }
        }

        private void Update()
        {
            // Collect horizontal directional inputs (Left/Right Arrows or A/D keys)
            horizontalInput = Input.GetAxisRaw("Horizontal");

            // Since character artwork natively faces LEFT, we pass inverted flags to correct directions
            if (horizontalInput > 0) UpdateVisualDirection(true);
            else if (horizontalInput < 0) UpdateVisualDirection(false);

            // --- 100% GUARANTEED SPRINT DETECTION LOOP ---
            isSprinting = false;

            // Direct Key Scan Check: Looks directly at your hardware keys to avoid Input Manager drops
            bool pressLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || horizontalInput < -0.1f;
            bool pressRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || horizontalInput > 0.1f;

            bool holdsLeftShift = Input.GetKey(KeyCode.LeftShift);
            bool holdsRightShift = Input.GetKey(KeyCode.RightShift);

            // Left Sprint: Explicitly requires moving left AND hitting Left Shift
            if (pressLeft && holdsLeftShift)
            {
                isSprinting = true;
            }
            // Right Sprint: Explicitly requires moving right AND hitting Right Shift
            else if (pressRight && holdsRightShift)
            {
                isSprinting = true;
            }

            // Calculate environmental positioning using explicit circular overlap evaluation
            if (groundCheckPoint != null)
            {
                isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
            }

            // Dynamically refresh tracking constants upon ground collision contact
            if (isGrounded)
            {
                jumpCount = 0;
            }

            // Accepts structural inputs from Spacebar ("Jump") or the Up Arrow Key
            if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                if (isGrounded || jumpCount < maxJumps - 1)
                {
                    ExecuteJump();
                }
            }

            // Enforce visual rendering switches based on physics evaluation cycles
            UpdateSpriteVisuals();
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            // Assign speed curves safely using inputs synchronized from the Update frame
            float currentSpeed = isSprinting ? sprintSpeed : walkSpeed;
            rb.linearVelocity = new Vector2(horizontalInput * currentSpeed, rb.linearVelocity.y);
        }

        private void ExecuteJump()
        {
            // Kill downward momentum trends before adding instant impulse thresholds
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpCount++;
        }

        private void UpdateVisualDirection(bool faceRight)
        {
            IsFacingRight = faceRight;
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = faceRight;
            }
        }

        private void UpdateSpriteVisuals()
        {
            if (spriteRenderer == null) return;

            // State Priority 1: Check mid-air status across both jump phases
            if (!isGrounded)
            {
                if (jumpSprite != null) spriteRenderer.sprite = jumpSprite;
            }
            // State Priority 2: Check horizontal input activity loops
            else if (Mathf.Abs(horizontalInput) > 0.1f)
            {
                if (runSprite != null) spriteRenderer.sprite = runSprite;
            }
            // State Priority 3: Fallback to idle positioning context
            else
            {
                if (standSprite != null) spriteRenderer.sprite = standSprite;
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (groundCheckPoint != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(groundCheckPoint.position, groundCheckRadius);
            }
        }
    }
}