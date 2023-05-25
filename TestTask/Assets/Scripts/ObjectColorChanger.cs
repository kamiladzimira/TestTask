using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ObjectColorChanger : MonoBehaviour
{
    private Renderer _renderer;
    private Color _cachedMaterialColor;
    private bool _shouldChangeColor;
    private float _timeBetweenColorChange = .2f;
    private float _timer = 0f;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _cachedMaterialColor = _renderer.material.GetColor("_Color");
    }

    private void Update()
    {
        if (!_shouldChangeColor)
        {
            return;
        }
        _timer += Time.deltaTime;
        if (_timer >= _timeBetweenColorChange)
        {
            _renderer.material.color = _cachedMaterialColor;
            _shouldChangeColor = false;
        }
    }

    public void ChangeObjectColor()
    {
        _shouldChangeColor = true;
        _timer = 0f;
        _renderer.material.color = Color.red;
    }
}
