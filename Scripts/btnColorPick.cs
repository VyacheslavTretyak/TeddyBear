using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnColorPick : MonoBehaviour {
	public ImagePrefab imgPref;
	public Sprite sprite;
	public Color[] colors;

	private SlidePanel slidePanel;
	private RectTransform rectTr;
	private float height;
	void Start () {
		slidePanel = FindObjectOfType<SlidePanel>();
		rectTr = GetComponent<RectTransform>();
		height = rectTr.anchoredPosition.y;
	}		
	public void OnClick()
	{
		slidePanel.SetHeightPosition(height);
		slidePanel.animator.SetBool("isShow", !slidePanel.animator.GetBool("isShow"));
	}
}
