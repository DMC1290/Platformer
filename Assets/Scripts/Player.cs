using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private float _walkForce = 5f;
    [SerializeField] ContactDetector _isGrounded;

    public UnityEvent finish;
      
    private Rigidbody2D _rb;

    bool _isJumping = false;
    private float _horizontalInput = 0;
  
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isJumping && _isGrounded.ContactDetected)
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }

        _rb.linearVelocityX = _horizontalInput * _walkForce;
    }

    public void OnJump(InputValue value)
    {
        Debug.Log("On Jump : Send Messages");
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("On jump : Unity Events");
        if (context.started)
        {
            Debug.Log("Jump!");
            _isJumping = true;
        }

        if (context.canceled)
        {
            Debug.Log("End Jump");
            _isJumping = false;
        }
    }

    public void OnWalk(InputAction.CallbackContext context)
    {
        _horizontalInput = context.ReadValue<float>();
        Debug.Log("On Run : " + _horizontalInput);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            finish.Invoke();
        }
    }
}