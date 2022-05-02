using TMPro;
using UnityEngine;

public class GameOverState : GameState
{
    [SerializeField] private SnakeMover _snakeMover;
    [SerializeField] private TMP_Text _currentScore;
    [SerializeField] private TMP_Text _highScore;
    [SerializeField] private Score _score;

    private void Start()
    {
        TurnOff();
    }

    private void OnEnable()
    {
        _snakeMover.GameOver += OnGameOver;
        _score.Changed += OnScoreChanged;
    }

    private void OnDisable()
    {
        _snakeMover.GameOver -= OnGameOver;
        _score.Changed -= OnScoreChanged;
    }

    private void OnGameOver()
    {
        AskForTransition();
    }

    public override void TurnOn()
    {
        Time.timeScale = 0;
        base.TurnOn();
    }

    private void OnScoreChanged(int score)
    {
        _highScore.text = $"High Score: {_score.HighScoreValue}";
        _currentScore.text = $"Score: {score}";
    }
}