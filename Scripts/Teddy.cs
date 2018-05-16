using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teddy : MonoBehaviour {
	private Color prevColor;
	public Color color;
	private void Start()
	{
		prevColor = color;
		SetColor();
	}
	private void Update()
	{
		if(color != prevColor)
		{
			prevColor = color;
			SetColor();
		}
	}
	private void SetColor()
	{
		SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
		foreach (SpriteRenderer item in sprites)
		{
			item.color = color;
		}
	}
}
