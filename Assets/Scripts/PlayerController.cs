using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool onGround;

    private float verticalInput;
    [SerializeField] private Rigidbody _rigidbody;

    //Camera
    [SerializeField] private  GameObject focalPoint;
    //Animacja
    [SerializeField] private Animator _animator;




    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        PlayerWalkAnimator();
    }

    private void FixedUpdate()
    {
        PlayerJump();
        _rigidbody.AddForce(focalPoint.transform.forward * verticalInput * movementSpeed * Time.fixedDeltaTime);
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            _rigidbody.AddForce(Time.fixedDeltaTime * jumpForce * Vector3.up, ForceMode.Impulse);
            onGround = false;
            _animator.SetTrigger("Jump");
        }
    }

    private void PlayerWalkAnimator()
    {
        if (verticalInput != 0 && onGround)
        {
            _animator.SetBool("Walk", true);
            _animator.SetFloat("VerticalMovement", verticalInput);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _animator.SetTrigger("Land");
        onGround = true;
    }
    public float VerticalInput { get => verticalInput; }
    public bool OnGround { get => onGround; }
}
