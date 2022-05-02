using UnityEngine.Events;

public class PlayButton : CustomButton
{
    public event UnityAction Pressed;

    protected override void OnPush()
    {
        Pressed?.Invoke();    
    }
}