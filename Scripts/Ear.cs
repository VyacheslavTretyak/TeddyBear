using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ear : MonoBehaviour
{
	private SpriteRenderer right;
	private SpriteRenderer left;
	private void Start()
	{
		SpriteRenderer[] sr = GetComponentsInChildren<SpriteRenderer>();
		right = sr[0];
		left = sr[1];
	}
	public void SetEar(Sprite sprite)
	{
		right.sprite = sprite;
		left.sprite = sprite;
	}


}
