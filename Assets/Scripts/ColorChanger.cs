using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private List<Color> _colors;
    [SerializeField] private int _colorChangeDuration;
    [SerializeField] private MeshRenderer _renderer;

    private Color currrentColor = Color.white;

    private void Update()
    {
        if (_renderer.material.color != currrentColor)
            _renderer.material.DOColor(currrentColor, _colorChangeDuration);
        else
            currrentColor = _colors[Random.Range(0, _colors.Count)];
    }
}