using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IButton
{
	float Height { get; set; }
	Resources Resources { get; set; }
	void OnClick();
}
