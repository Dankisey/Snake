using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayState : GameState
{
    [SerializeField] private List<PlayButton> _playButtons;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Image _pausePanel;
    [SerializeField] private Snake _snake;
    [SerializeField] private Score _score;

    private float _gameSpeed = 1;
    private bool _isPaused = false;
    private bool _isPlaying;

    public void SetSpeed(float gameSpeed)
    {
        _gameSpeed = gameSpeed;
    }

    public override void TurnOn()
    {
        Time.timeScale = _gameSpeed;

        _snake.Reset();
        _score.Reset();
        _isPlaying = true;

        _pauseButton.gameObject.SetActive(true);

        base.TurnOn();
    }

    public override void TurnOff()
    {
        _isPlaying = false;
        base.TurnOff();
    }

    public void Pause()
    {
        _pausePanel.gameObject.SetActive(true);
        _pauseButton.gameObject.SetActive(false);

        Time.timeScale = 0;
        _isPaused = true;
    }

    public void Resume()
    {
        _pausePanel.gameObject.SetActive(false);
        _pauseButton.gameObject.SetActive(true);

        Time.timeScale = _gameSpeed;
        _isPaused = false;
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (_isPlaying)
        {
            if (_isPaused)
                Resume();
            else
                Pause();
        }    
    }

    private void OnEnable()
    {
        foreach (var playButton in _playButtons)
        {
            playButton.Pressed += OnMenuButtonPressed;
        }

        _pausePanel.gameObject.SetActive(false);
        _pauseButton.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        foreach (var playButton in _playButtons)
        {
            playButton.Pressed -= OnMenuButtonPressed;
        }
    }

    private void OnMenuButtonPressed()
    {
        Resume();
        AskForTransition();
    }
}