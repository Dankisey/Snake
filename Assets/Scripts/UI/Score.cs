using UnityEngine.Events;
using UnityEngine;

public class Score : MonoBehaviour
{
    public event UnityAction<int> Changed;
    
    [SerializeField] private Eater _eater;

    private const string HighScore = nameof(HighScore);

    public int HighScoreValue { get; private set; }
    private int _score;

    public void Reset()
    {
        _score = 0;
        Changed?.Invoke(_score);
    }

    private void OnEnable()
    {
        Changed?.Invoke(_score);
        _eater.FoodEaten += OnFoodEaten;

        if (PlayerPrefs.HasKey(HighScore) == false)
        {
            HighScoreValue = 0;
            PlayerPrefs.SetInt(HighScore, HighScoreValue);
        }
        else
        {
            HighScoreValue = PlayerPrefs.GetInt(HighScore);
        }
    }

    private void OnDisable()
    {
        _eater.FoodEaten -= OnFoodEaten;
    }    

    private void OnFoodEaten()
    {
        _score++;

        if (PlayerPrefs.GetInt(HighScore) < _score)
        {
            HighScoreValue = _score;

            PlayerPrefs.SetInt(HighScore, HighScoreValue);
        }

        Changed?.Invoke(_score);
    }
}