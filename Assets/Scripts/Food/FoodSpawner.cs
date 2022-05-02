using UnityEngine;
using UnityEngine.Events;

public class FoodSpawner : MonoBehaviour
{
    [Range(0, 1)] [SerializeField] private float _raycastDistance;
    [SerializeField] private int _minX;
    [SerializeField] private int _maxX;
    [SerializeField] private int _minY;
    [SerializeField] private int _maxY;
    [SerializeField] private Eater _eater;
    [SerializeField] private Snake _snake;
    [SerializeField] private Food _prefab;

    private int _maxSpawnedFood;
    private int _spawnedFood = 0;
    private Vector2 _newPosition;
    private Food _food;

    public event UnityAction Victory;

    private void OnEnable()
    {
        _eater.FoodEaten += OnFoodEaten;
    }

    private void OnDisable()
    {
        _eater.FoodEaten -= OnFoodEaten;
    }

    private void Start()
    {
        //the area of the spawnzone of apples by coordinates (with little offset)
        _maxSpawnedFood = (int)(Mathf.Sqrt(Mathf.Pow(_maxX - _minX + 1, 2)) * (Mathf.Sqrt(Mathf.Pow(_maxY - _minY + 1, 2)))) - _snake.StartSize * 3;
        _food = Instantiate(_prefab);

        Replace();
    }

    private void OnFoodEaten()
    {
        Replace();
    }

    private void GetNewPosition()
    {
        bool isSearchingPosition = true;

        while (isSearchingPosition)
        {
            _newPosition = new Vector2(Random.Range(_minX, _maxX + 1), Random.Range(_minY, _maxY + 1));
            var raycastCollider = Physics2D.Raycast(_newPosition, Vector2.up, _raycastDistance).collider;

            isSearchingPosition = raycastCollider != null;
        }
    }

    private void Replace()
    {
        _food.gameObject.SetActive(false);

        if (_spawnedFood >= _maxSpawnedFood)
        {
            Victory?.Invoke();
        }
        else
        {
            GetNewPosition();
            _food.transform.position = _newPosition;

            _food.gameObject.SetActive(true);

            _spawnedFood++;
        }  
    }
}