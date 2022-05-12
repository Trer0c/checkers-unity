using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    private Transform _transform;
    private Image _image;
    private TileInfo _tileInfo;
    private GameObject _go;
    private Vector3 _offset;
    private Vector3 _startPos;
    private Vector3 _activePos;
    private float _distance;
    private int _indexBoard;
    private int _indexData;

    private void Awake()
    {
        _transform = transform;
        _image = GetComponent<Image>();
        _tileInfo = GetComponent<TileInfo>();
    }

    private void OnMouseDown()
    {
        _offset = _transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        _startPos = _transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        _transform.position = Camera.main.ScreenToWorldPoint(newPosition) + _offset;
        if (_transform.localPosition.x >= 420)
        {
            _transform.localPosition = new Vector3(420, _transform.localPosition.y, _transform.localPosition.z);
        }
        else if (_transform.localPosition.x <= -420)
        {
            _transform.localPosition = new Vector3(-420, _transform.localPosition.y, _transform.localPosition.z);
        }
        if (_transform.localPosition.y >= 420)
        {
            _transform.localPosition = new Vector3(_transform.localPosition.x, 420, _transform.localPosition.z);
        }
        else if (_transform.localPosition.y <= -420)
        {
            _transform.localPosition = new Vector3(_transform.localPosition.x, -420, _transform.localPosition.z);
        }
    }

    private void OnMouseUp()
    {
        _activePos = _transform.position;
        _go = null;
        _distance = 1000;
        _indexBoard = 0;
        _indexData = 0;
    }

    private void SwitchTile()
    {
        
    }
}
