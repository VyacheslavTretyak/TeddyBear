using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePanel : MonoBehaviour {
	public Animator animator;
	private RectTransform rectTr;
	void Start () {
		animator = GetComponent<Animator>();
		rectTr = GetComponent<RectTransform>();
	}	
	public void SetHeightPosition(float height)
	{
		rectTr.anchoredPosition = new Vector2(rectTr.anchoredPosition.x, height);
	}
}
