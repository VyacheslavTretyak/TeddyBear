using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
	public static GameObject dragObject;
	private Vector3 startPosition;
	private Teddy teddy;
	private void Start()
	{
		teddy = FindObjectOfType<Teddy>();
	}
	public void OnBeginDrag(PointerEventData eventData)
	{
		dragObject = gameObject;
		startPosition = transform.position;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if (hit.collider != null)
		{
			switch (dragObject.GetComponent<ResoursPlace>().type)
			{
				case ResoursType.Color:
					teddy.SetColor(DragHandler.dragObject.GetComponent<Image>().color);
					break;
				case ResoursType.Ear:
					teddy.SetEars(DragHandler.dragObject.GetComponent<Image>().sprite);
					break;
				case ResoursType.Eye:
					teddy.SetEyes(DragHandler.dragObject.GetComponent<Image>().sprite);
					break;
				case ResoursType.Bow:
					teddy.SetBow(DragHandler.dragObject.GetComponent<Image>().sprite);
					break;
			}
		}
		dragObject = null;
		transform.position = startPosition;
	}
}
