using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ResoursType
{
	Color,
	Ear,
	Eye,
	Bow
}

public class ResoursPlace : MonoBehaviour
{
	[HideInInspector]
	public Animator animator;
	[HideInInspector]
	public Image image;
	[HideInInspector]
	public RectTransform rectTr;
	[HideInInspector]
	public Resources res;
	public ResoursType type;

	
	void Awake () {		
		image = GetComponent<Image>();
		rectTr = GetComponent<RectTransform>();
		animator = GetComponent<Animator>();		
	}
	private void Update()
	{
		animator.SetBool("IsAppier", res.slidePanel.triggerAfrerOpen);		
	}
}
