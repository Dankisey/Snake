using UnityEngine;

public class Teleporter : MonoBehaviour
{
    //used to fix some bugs and visual issues
    [SerializeField] private float _offset;
    //
    [SerializeField] private Snake _snake;

    private float _xBorder;
    private float _yBorder;

    private void Start()
    {
        _xBorder = Mathf.Abs(Camera.main.ScreenToWorldPoint(new Vector3(1, 0)).x);
        _yBorder = Mathf.Abs(Camera.main.ScreenToWorldPoint(new Vector3(0, 1)).y);
    }

    private void FixedUpdate() 
    {
        if (Mathf.Abs(_snake.transform.position.x) > _xBorder + _offset || Mathf.Abs(_snake.transform.position.y) > _yBorder + _offset)
            Teleport();     
    }

    private void Teleport()
    {
        if (Mathf.Abs(_snake.transform.position.x) > _xBorder)
        {
            _snake.transform.position = new Vector3(Flip(_snake.transform.position.x), _snake.transform.position.y);
        }
        else
        {
            _snake.transform.position = new Vector3(_snake.transform.position.x, Flip(_snake.transform.position.y));
        }
    }

    private float Flip(float coordinate)
    {
        coordinate *= -1;

        if (coordinate < 0)
            coordinate++;
        else
            coordinate--;

        return coordinate;
    }
}