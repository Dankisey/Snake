using UnityEngine;

public class PauseButton : CustomButton
{
    [SerializeField] private PlayState _playState;

    protected override void OnPush()
    {
        _playState.Pause();
    }
}