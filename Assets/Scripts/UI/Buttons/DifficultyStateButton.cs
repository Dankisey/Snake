using UnityEngine.Events;

public class DifficultyStateButton: CustomButton
{
    public event UnityAction Pressed;

    protected override void OnPush()
    {
        Pressed?.Invoke();
    }
}