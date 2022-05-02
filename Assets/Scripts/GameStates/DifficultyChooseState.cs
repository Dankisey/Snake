using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifficultyChooseState : GameState
{
    [SerializeField] private List<DifficultyStateButton> _difficultyChooseButtons;
    [SerializeField] private GameStatesMachine _stateMachine;
    [SerializeField] private TMP_Text _difficultyText;
    [SerializeField] private float _normalDifficultySpeed;

    public void ChangeDifficulty(float gameSpeed)
    {
        _stateMachine.ChangeDifficulty(gameSpeed);
    }

    public override void TurnOn()
    {
        base.TurnOn();
    }

    private void Start()
    {
        _difficultyText.text = "Difficulty: Normal";
        ChangeDifficulty(_normalDifficultySpeed);
        TurnOff();
    }

    private void OnEnable()
    {
        foreach (var difficultyChooseButton in _difficultyChooseButtons)
        {
            difficultyChooseButton.Pressed += OnChooseDifficultyButtonPressed;
        }
    }

    private void OnDisable()
    {
        foreach (var difficultyChooseButton in _difficultyChooseButtons)
        {
            difficultyChooseButton.Pressed -= OnChooseDifficultyButtonPressed;
        }
    }

    private void OnChooseDifficultyButtonPressed()
    {
        AskForTransition();
    }
}