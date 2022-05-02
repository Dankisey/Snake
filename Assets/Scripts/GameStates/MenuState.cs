using System.Collections.Generic;
using UnityEngine;

public class MenuState : GameState
{    
    [SerializeField] private List<MenuButton> _menuButtons;

    public override void TurnOn()
    {
        Time.timeScale = 0;
        base.TurnOn();
    }

    private void OnEnable()
    {
        foreach (var menuButton in _menuButtons)
        {
            menuButton.Pressed += OnMenuButtonPressed;
        }
    }

    private void OnDisable()
    {
        foreach (var menuButton in _menuButtons)
        {
            menuButton.Pressed -= OnMenuButtonPressed;
        }
    }

    private void OnMenuButtonPressed()
    {
        AskForTransition();
    }
}