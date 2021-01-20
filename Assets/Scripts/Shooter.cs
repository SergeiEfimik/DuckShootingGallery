using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class Shooter : MonoBehaviour
{
    [SerializeField] private AudioClip _shootClip;
    [SerializeField] private AudioClip _hitClip;
    [SerializeField] private TMP_Text _scoreText;

    private Camera _camera;
    private PlayerInput _input;
    private AudioSource _audioSource;
    private int _score;

    private void Awake()
    {
        _input = new PlayerInput();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _input.Enable();
        _input.Player.Click.performed += context => OnClick();
    }

    private void OnDisable()
    {
        _input.Disable();
        _input.Player.Click.performed -= context => OnClick();
    }

    private void Start()
    {
        _camera = Camera.main;
        _score = 0;
    }
    
    private void OnClick()
    {
        _audioSource.PlayOneShot(_shootClip);

        Vector2 clickPosition = _input.Player.ClickPosition.ReadValue<Vector2>();
        Ray shootingRay = _camera.ScreenPointToRay(clickPosition);
        RaycastHit2D hitInfo = Physics2D.Raycast(shootingRay.origin, shootingRay.direction);

        if (hitInfo.collider != null &&
            hitInfo.collider.TryGetComponent(out Target target))
        {
            if (target.IsShootable)
            {
                target.Hit();
                _score++;
                _scoreText.text = "x " + _score;
                _audioSource.PlayOneShot(_hitClip);
            }
        }
    }
}