using UnityEngine.Events;

public class MenuButton : CustomButton
{
    public event UnityAction Pressed;

    protected override void OnPush()
    {
        Pressed?.Invoke();
    }
}