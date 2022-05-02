using System.Collections.Generic;
using UnityEngine;

public class GameStatesMachine : MonoBehaviour
{
    [SerializeField] private List<GameState> _gameStates;
    [SerializeField] private GameState _startState;

    private GameState _currentState;
    private float _gameSpeed;

    public void ChangeDifficulty(float gameSpeed)
    {
        _gameSpeed = gameSpeed;
    }

    private void OnEnable()
    {
        foreach (var state in _gameStates)
        {
            state.AskedForTransition += OnTransitionAsked;
        }
    }

    private void OnDisable()
    {
        foreach (var state in _gameStates)
        {
            state.AskedForTransition -= OnTransitionAsked;
        }
    }

    private void Start()
    {
        foreach (var state in _gameStates)
            state.TurnOff();
        
        Reset(_startState);
    }

    private void Reset(GameState startState)
    {
        _currentState = startState;

        if (_currentState != null)
            _currentState.TurnOn();
    }

    private void DoTransit(GameState nextState)
    {
        if (_currentState != null)
            _currentState.TurnOff();

        _currentState = nextState;

        if (_currentState != null)
        {
            if (_currentState is PlayState)
            {
                PlayState playState = (PlayState)_currentState;
                playState.SetSpeed(_gameSpeed);
            }

            _currentState.TurnOn();
        }

    }

    private void OnTransitionAsked(GameState gameState)
    {
        DoTransit(gameState);
    }
}