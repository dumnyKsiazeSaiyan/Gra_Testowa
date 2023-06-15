using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject player;
    private float horizontalInput;

    Vector3 offset;
    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void LateUpdate()
    {
        transform.Rotate(Time.deltaTime * HorizontalInput * rotationSpeed * Vector3.up);

        transform.position = player.transform.position + offset;
        player.transform.rotation = Quaternion.Euler( new Vector3(player.transform.rotation.x,
                                                                  transform.rotation.eulerAngles.y,
                                                                  player.transform.rotation.z));
    }

    
    public float HorizontalInput { get => horizontalInput; }
}
