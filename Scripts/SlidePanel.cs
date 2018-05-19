using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePanel : MonoBehaviour {
	[HideInInspector]
	public Animator animator;
	[HideInInspector]
	public bool IsOpened { get; set; }
	public bool triggerAfrerOpen = false;
	public bool triggerAfrerHide = false;
	private RectTransform rectTr;
	[HideInInspector]
	public RectTransform backPanelRect;
	
	void Awake () {
		IsOpened = false;
		animator = GetComponent<Animator>();
		rectTr = GetComponent<RectTransform>();
		backPanelRect = GetComponentInChildren<BackPanel>().GetComponent<RectTransform>();
	}	
	public void SetUpBackPanel(float height)
	{
		backPanelRect.anchoredPosition = new Vector2(backPanelRect.anchoredPosition.x, height);		
	}	
	public void OpenPanel()
	{		
		IsOpened = true;
		animator.SetBool("isShow", IsOpened);
	}
	public void ClosePanel()
	{
		triggerAfrerOpen = false;
		IsOpened = false;
		animator.SetBool("isShow", IsOpened);		
	}
	public void AfterOpen()
	{
		triggerAfrerOpen = true;
	}
	public void AfterHide()
	{
		triggerAfrerHide = true;
	}
}
