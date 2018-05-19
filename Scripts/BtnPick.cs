using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnPick :MonoBehaviour
{
	public float Height { get; set; }
	public Resources Resources { get; set; }	

	private void Start()
	{
		Height = GetComponent<RectTransform>().anchoredPosition.y;
		Resources = FindObjectOfType<Resources>();
	}
	public void OnClick()
	{		
		Resources.ButtonClick(this.gameObject);
	}
}
