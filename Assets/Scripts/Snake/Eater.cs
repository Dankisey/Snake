using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Snake))]

public class Eater: MonoBehaviour
{
    [SerializeField] private ParticleSystem _foodParticles;

    public event UnityAction FoodEaten;

    public void Eat()
    {
        _foodParticles.Play();
        FoodEaten?.Invoke();
    }
}