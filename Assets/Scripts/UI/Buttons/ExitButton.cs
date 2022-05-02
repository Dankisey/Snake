using UnityEngine;

public class ExitButton : CustomButton
{
    protected override void OnPush()
    {
        Application.Quit();
    }
}