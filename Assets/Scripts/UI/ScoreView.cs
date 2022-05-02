using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreView;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        _score.Changed += OnScoreIncreased;
    }

    private void OnDisable()
    {
        _score.Changed -= OnScoreIncreased;
    }

    private void OnScoreIncreased(int score)
    {
        _scoreView.text = score.ToString();
    }
}