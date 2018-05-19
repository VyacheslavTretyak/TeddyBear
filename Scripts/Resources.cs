using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
	private ResoursPlace[] resours;
	//private ResoursPlace[] resEars;
	//private ResoursPlace[] resEyes;
	//private ResoursPlace[] resBows;

	public ResoursPlace resPlacePref;
	public Sprite colorBack;
	public Color[] bodyColors;
	public Sprite[] ears;
	public Sprite[] eyes;
	public Sprite[] bows;
	[HideInInspector]
	public SlidePanel slidePanel;
	private void Start()
	{
		slidePanel = FindObjectOfType<SlidePanel>();		
	}
	private void Update()
	{
		if (slidePanel.triggerAfterHide)
		{
			if (resours == null)
			{
				slidePanel.triggerAfterHide = false;
			}
			foreach (ResoursPlace item in resours)
			{
				GameObject.Destroy(item.gameObject);
			}
			resours = null;
			slidePanel.triggerAfterHide = false;
		}
	}
	internal void ButtonClick(GameObject btn)
	{		
		switch (btn.name)
		{
			case "btnColorPick":
				GetColorRes(btn.GetComponent<RectTransform>().anchoredPosition.y);
				break;
			case "btnEarPick":
				GetEarsRes(btn.GetComponent<RectTransform>().anchoredPosition.y);
				break;
			case "btnEyePick":
				GetEyesRes(btn.GetComponent<RectTransform>().anchoredPosition.y);
				break;
			case "btnBowPick":
				GetBowsRes(btn.GetComponent<RectTransform>().anchoredPosition.y);
				break;

		}
	}
	private void GetColorRes(float height)
	{		
		if (!slidePanel.IsOpened && resours==null)
		{
			resours = new ResoursPlace[bodyColors.Length];
			for (int i = 0; i < bodyColors.Length; i++)
			{
				ResoursPlace pl = Instantiate(resPlacePref);
				pl.image.sprite = colorBack;
				pl.image.color = bodyColors[i];
				pl.transform.SetParent(slidePanel.backPanelRect.transform);
				pl.rectTr.sizeDelta = new Vector2(40, 40);
				pl.res = this;
				pl.type = ResoursType.Color;
				resours[i] = pl;
			}
			slidePanel.SetUpBackPanel(height);
			slidePanel.OpenPanel();
		}
		else
		{
			slidePanel.ClosePanel();			
		}		
	}
	private void GetEarsRes(float height)
	{
		if (!slidePanel.IsOpened && resours == null)
		{
			resours = new ResoursPlace[ears.Length];
			for (int i = 0; i < ears.Length; i++)
			{
				ResoursPlace pl = Instantiate(resPlacePref);
				pl.image.sprite = ears[i];				
				pl.transform.SetParent(slidePanel.backPanelRect.transform);
				pl.rectTr.sizeDelta = new Vector2(40, 40);
				pl.type = ResoursType.Ear;
				pl.res = this;
				resours[i] = pl;
			}
			slidePanel.SetUpBackPanel(height);
			slidePanel.OpenPanel();
		}
		else
		{
			slidePanel.ClosePanel();
		}
	}
	private void GetEyesRes(float height)
	{
		if (!slidePanel.IsOpened && resours == null)
		{
			resours = new ResoursPlace[eyes.Length];
			for (int i = 0; i < eyes.Length; i++)
			{
				ResoursPlace pl = Instantiate(resPlacePref);
				pl.image.sprite = eyes[i];
				pl.transform.SetParent(slidePanel.backPanelRect.transform);
				pl.rectTr.sizeDelta = new Vector2(40, 40);
				pl.res = this;
				pl.type = ResoursType.Eye;
				resours[i] = pl;
			}
			slidePanel.SetUpBackPanel(height);
			slidePanel.OpenPanel();
		}
		else
		{
			slidePanel.ClosePanel();
		}
	}
	private void GetBowsRes(float height)
	{
		if (!slidePanel.IsOpened && resours == null)
		{
			resours = new ResoursPlace[bows.Length];
			for (int i = 0; i < bows.Length; i++)
			{
				ResoursPlace pl = Instantiate(resPlacePref);
				pl.image.sprite = bows[i];
				pl.transform.SetParent(slidePanel.backPanelRect.transform);
				pl.rectTr.sizeDelta = new Vector2(40, 40);
				pl.res = this;
				pl.type = ResoursType.Bow;
				resours[i] = pl;
			}
			slidePanel.SetUpBackPanel(height);
			slidePanel.OpenPanel();
		}
		else
		{
			slidePanel.ClosePanel();
		}
	}
}
