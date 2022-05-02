using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Snake))]

public class SnakeMover : MonoBehaviour
{
    public event UnityAction GameOver;

    [SerializeField] private ParticleSystem _bumpParticles;
    [SerializeField] private Eater _eater;
    [SerializeField] private float _stepTime;
    
    private List<Transform> _tails;
    private Vector3 _lastStepDirection;
    private Vector3 _startPosition;
    private Vector3 _moveDirection;
    private float _elapsedTime = 0;
    private float _lastForcedStepElapsedTime = 0;
    private float _forcedStepInterval;

    public void OnGoUp(InputAction.CallbackContext context)
    {
        if (_moveDirection != Vector3.up && Vector3.up != _lastStepDirection * -1)
        {
            _moveDirection = Vector3.up;
            transform.eulerAngles = new Vector3(0, 0, 0);

            if (_lastForcedStepElapsedTime >= _forcedStepInterval && _elapsedTime >= _forcedStepInterval)
            {
                _lastForcedStepElapsedTime = 0;
                Move();
            }          
        }
    }

    public void OnGoDown(InputAction.CallbackContext context)
    {
        if (_moveDirection != Vector3.down && Vector3.down != _lastStepDirection * -1)
        {
            _moveDirection = Vector3.down;
            transform.eulerAngles = new Vector3(0, 0, 180);

            if (_lastForcedStepElapsedTime >= _forcedStepInterval && _elapsedTime >= _forcedStepInterval)
            {
                _lastForcedStepElapsedTime = 0;
                Move();
            }
        }
    }

    public void OnGoLeft(InputAction.CallbackContext context)
    {
        if (_moveDirection != Vector3.left && Vector3.left != _lastStepDirection * -1)
        {
            _moveDirection = Vector3.left;
            transform.eulerAngles = new Vector3(0, 0, 90);

            if (_lastForcedStepElapsedTime >= _forcedStepInterval && _elapsedTime >= _forcedStepInterval)
            {
                _lastForcedStepElapsedTime = 0;
                Move();
            }
        }
    }

    public void OnGoRight(InputAction.CallbackContext context)
    {
        if (_moveDirection != Vector3.right && Vector3.right != _lastStepDirection * -1)
        {
            _moveDirection = Vector3.right;
            transform.eulerAngles = new Vector3(0,0,-90);

            if (_lastForcedStepElapsedTime >= _forcedStepInterval && _elapsedTime >= _forcedStepInterval)
            {
                _lastForcedStepElapsedTime = 0;
                Move();
            }
        }    
    }

    public void Init(List<Transform> tails)
    {
        _tails = tails;
    }

    public void Reset()
    {
        foreach (var tail in _tails)
        {
            tail.position = _startPosition;
        }

        _moveDirection = Vector2.up;
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    private void Start()
    {
        _forcedStepInterval = _stepTime / 2;

        transform.position = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
        _startPosition = transform.position;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        _lastForcedStepElapsedTime += Time.deltaTime;

        if (_elapsedTime >= _stepTime)      
            Move();       
    }

    private void Move()
    {
        _elapsedTime = 0;

        CheckNextStep();

        _lastStepDirection = _moveDirection;

        if (_tails != null)
        {
            for (int i = _tails.Count - 1; i > 0; i--)
            {
                _tails[i].position = _tails[i - 1].position;
            }
        }
        
        transform.position += _moveDirection;
    }

    private void CheckNextStep()
    {
        RaycastHit2D rayCastHit = Physics2D.Raycast(transform.position + _moveDirection, Vector2.up, 0.1f);

        if (rayCastHit.collider != null)
        {
            if (rayCastHit.collider.TryGetComponent<Wall>(out Wall wall) || rayCastHit.collider.TryGetComponent<Tail>(out Tail tail))
            {
                _moveDirection = Vector3.zero;
                _bumpParticles.Play();
                GameOver?.Invoke();
                return;
            }

            if (rayCastHit.collider.TryGetComponent<Food>(out Food food))
            {
                _eater.Eat();
            }
        }
    }
}