using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Snake : MonoBehaviour
{
    public int StartSize => _startSize;
    
    [SerializeField] private Tail _tailPrefab;
    [SerializeField] private SnakeMover _mover;
    [SerializeField] private Eater _eater;
    [SerializeField] private int _startSize;

    private List<Transform> _tails;

    public void Reset()
    {
        if (_tails != null)
        {
            foreach (var tail in _tails)
            {
                if (tail != transform)
                {
                    Destroy(tail.gameObject);
                }
            }
        }
        
        _tails = new List<Transform>();
        _tails.Add(transform);
        _mover.Init(_tails);

        MakeStartSize();
        _mover.Reset();
    }

    private void GrowUp()
    {
        var newTail = Instantiate(_tailPrefab, _tails[_tails.Count - 1].transform.position, _tails[_tails.Count -1].rotation);
        _tails.Add(newTail.transform);
    }

    private void OnEnable()
    {     
        _eater.FoodEaten += OnFoodEaten;
    }

    private void OnDisable()
    {
        _eater.FoodEaten -= OnFoodEaten;
    }

    private void MakeStartSize()
    {
        for (int i = 0; i < _startSize; i++)
        {
            GrowUp();
        }
    }

    private void OnFoodEaten()
    {
        GrowUp();
    }
}