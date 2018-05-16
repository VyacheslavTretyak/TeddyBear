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
		LoadColors();

	}
	private void LoadColors()
	{
		foreach (Color col in colors)
		{
			ImagePrefab imageObj = Instantiate(imgPref);
			Image img = imageObj.GetComponent<Image>();
			img.sprite = sprite;			
			img.color = col;
			imageObj.GetComponent<RectTransform>().anchoredPosition = rectTr.anchoredPosition;
			imageObj.transform.SetParent(slidePanel.transform);
		}
	}
}
