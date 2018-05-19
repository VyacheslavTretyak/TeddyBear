//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teddy : MonoBehaviour {
	private Color prevColor;
	private Animator animator;
	public Color startColor;
	private Ear ears;
	private Eye eyes;
	private Bow bow;
	private void Start()
	{
		animator = GetComponent<Animator>();
		ears = GetComponentInChildren<Ear>();
		eyes = GetComponentInChildren<Eye>();
		bow = GetComponentInChildren<Bow>();
		SetColor(startColor);

	}
	private void Update()
	{
		switch ((int)(Random.value * 1000))
		{
			case 1:
				animator.SetTrigger("SetHand");
				break;
			case 2:
				animator.SetTrigger("SetBow");
				break;
			case 3:
				animator.SetTrigger("SetEar");
				break;
			case 4:
				animator.SetTrigger("SetEye");
				break;
		}

	}
	public void SetColor(Color color)
	{
		SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
		foreach (SpriteRenderer item in sprites)
		{
			if (item.GetComponent<Bow>() == null && item.gameObject.GetComponentInParent<Eye>() == null)
			{
				item.color = color;
			}
		}
		animator.SetTrigger("SetHand");
	}

	internal void SetEars(Sprite sprite)
	{
		ears.SetEar(sprite);
		animator.SetTrigger("SetEar");
	}
	internal void SetEyes(Sprite sprite)
	{
		eyes.SetEye(sprite);
		animator.SetTrigger("SetEye");
	}
	internal void SetBow(Sprite sprite)
	{
		bow.GetComponent<SpriteRenderer>().sprite = sprite;
		animator.SetTrigger("SetBow");
	}
}
