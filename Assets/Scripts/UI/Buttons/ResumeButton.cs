using UnityEngine;

public class ResumeButton : CustomButton
{
    [SerializeField] private PlayState _playState;

    protected override void OnPush()
    {
        _playState.Resume();
    }
}