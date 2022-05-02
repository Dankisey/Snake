using TMPro;
using UnityEngine;

public class VictoryState : GameState
{
    [SerializeField] FoodSpawner _spawner;
    [SerializeField] private TMP_Text _currentScore;
    [SerializeField] private TMP_Text _highScore;
    [SerializeField] private Score _score;

    public override void TurnOn()
    {
        Time.timeScale = 0;
        base.TurnOn();
    }

    public override void TurnOff()
    {
        Time.timeScale = 1;
        base.TurnOff();
    }

    private void OnEnable()
    {
        _score.Changed += OnScoreChanged;
        _spawner.Victory += OnVictory;
    }

    private void OnDisable()
    {
        _score.Changed -= OnScoreChanged;
        _spawner.Victory -= OnVictory;
    }

    private void OnVictory()
    {
        AskForTransition();
    }

    private void OnScoreChanged(int score)
    {
        _highScore.text = $"High Score: {_score.HighScoreValue}";
        _currentScore.text = $"Score: {score}";
    }
}
