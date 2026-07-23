using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class MenuButton
{
	public string description;

	public string name;

	public CanvasGroup canvas;

	public Image sceneImage;

	public Color normalColor;

	public Color highlightedColor;

	public UnityEvent method;
}
