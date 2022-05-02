using UnityEngine;
using UnityEngine.UI;

public abstract class CustomButton : MonoBehaviour
{
    [SerializeField] protected Button Button;

    private void OnEnable()
    {
        Button.onClick.AddListener(OnPush);
    }

    private void OnDisable()
    {
        Button.onClick.RemoveListener(OnPush);
    }

    protected abstract void OnPush();
}