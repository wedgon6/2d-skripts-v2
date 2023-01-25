using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChenger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;

    public void Chenge()
    {
        _renderer.color = _color;
    }
}
