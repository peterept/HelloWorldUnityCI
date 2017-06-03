using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Colorer : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData eventData)
	{		
		Debug.Log("Clicked" + name);        
		GetComponent<Renderer> ().material.color = Random.ColorHSV (0, 1);
	}
}
