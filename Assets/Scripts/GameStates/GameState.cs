using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class GameState : MonoBehaviour
{
    public event UnityAction<GameState> AskedForTransition;

    [SerializeField] protected CanvasGroup CanvasGroup;

    public virtual void TurnOn()
    {
        CanvasGroup.alpha = 1;
        CanvasGroup.interactable = true;
        CanvasGroup.blocksRaycasts = true;
    }

    public virtual void TurnOff()
    {
        CanvasGroup.alpha = 0;
        CanvasGroup.interactable = false;
        CanvasGroup.blocksRaycasts = false;
    }

    protected void AskForTransition()
    {
        AskedForTransition?.Invoke(this);
    }
}
