using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    Color _ballColor;

    Renderer _renderer;
    Material _defaultMaterial;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _defaultMaterial = _renderer.material;
        _ballColor = Color.HSVToRGB(Random.Range(0f, 1f), .6f, .8f);

        SetColor();
    }

    private void SetColor()
    {
        _defaultMaterial.color = _ballColor;
    }
}
