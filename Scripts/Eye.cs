using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
	private SpriteRenderer right;
	private SpriteRenderer left;
	private void Start()
	{
		SpriteRenderer[] sr = GetComponentsInChildren<SpriteRenderer>();
		right = sr[0];
		left = sr[1];
	}
	public void SetEye(Sprite sprite)
	{
		right.sprite = sprite;
		left.sprite = sprite;
	}
}
