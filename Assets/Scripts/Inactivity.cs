using UnityEngine;

public class Inactivity : MonoBehaviour
{
    [SerializeField]private CameraControll _cameraControll;
    [SerializeField]private PlayerController _playerController;

    private Camera _camera;
    private float startFOV;

    [SerializeField] private bool inactivity;
    private float timeToInactivity = 3;
    public float timer;

    private void Start()
    {
        if (gameObject.name == "Camera_Player1")
        {
            _cameraControll = GameObject.Find("Focal_Point_Player1").GetComponent<CameraControll>();
            _playerController = GameObject.Find("Player1").GetComponent<PlayerController>();
        }

        _camera = GetComponent<Camera>();
        startFOV = _camera.fieldOfView;
    }
    private void FixedUpdate()
    {
        if (IsPlayerActive() && _camera.fieldOfView < 60)
            _camera.fieldOfView += 0.2f;
        else if (!IsPlayerActive() && _camera.fieldOfView > startFOV)
        {
            _camera.fieldOfView -= 0.8f;
            if (_camera.fieldOfView < startFOV)
                _camera.fieldOfView = startFOV;
        }
    }
    private bool IsPlayerActive()
    {
        if (_cameraControll.HorizontalInput != 0 || _playerController.VerticalInput != 0 || !_playerController.OnGround)
        {
            timer = 0;
            return false;
        }

        timer += Time.deltaTime;
        if (timer >= timeToInactivity)
            return true;
        return false;
    }
}
