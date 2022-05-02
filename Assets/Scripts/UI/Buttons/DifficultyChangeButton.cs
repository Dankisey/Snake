using TMPro;
using UnityEngine;

public class DifficultyChangeButton : CustomButton
{
    [SerializeField] private DifficultyChooseState _difficultyChooseState;
    [SerializeField] private TMP_Text _difficultyText;
    [SerializeField] private string _difficultyName;
    [SerializeField] private float _difficultySpeed;

    protected override void OnPush()
    {
        _difficultyChooseState.ChangeDifficulty(_difficultySpeed);
        _difficultyText.text = "Difficulty: " + _difficultyName;
    }
}