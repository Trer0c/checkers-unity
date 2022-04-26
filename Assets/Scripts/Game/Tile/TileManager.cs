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

    private void Awake()
    {
        _transform = transform;
        _image = GetComponent<Image>();
        _tileInfo = GetComponent<TileInfo>();
    }

    private void OnMouseDown()
    {

    }

    private void OnMouseDrag()
    {

    }

    private void OnMouseUp()
    {

    }
}
