// MR Starter Kit - Children's Mercy KC
// Copyright 2018 Children’s Mercy Hospital. All rights reserved.
// Licensed under the Apache License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Class for adding custom Select behavior.
    /// </summary>
    public class Selectable
  {
    public Color FocusedColor = Color.yellow;
    public Color SelectedColor = Color.red;

    private Color _originalColor;    
    private Material _cachedMaterial;
    private MonoBehaviour _source;
    private bool _isSelected;

    public Selectable(MonoBehaviour source)
    {
      _source = source;
      _cachedMaterial = _source.GetComponent<Renderer>().material;
      _originalColor = _cachedMaterial.GetColor("_Color");
    }

    public void Select()
    {
      _isSelected = !_isSelected;
    }

    public void Enter()
    {
      _cachedMaterial.SetColor("_Color", FocusedColor);
    }

    public void Exit()
    { 
      if (_isSelected)
        _cachedMaterial.SetColor("_Color", SelectedColor);
      else
        _cachedMaterial.SetColor("_Color", _originalColor);

    }
  }
}
