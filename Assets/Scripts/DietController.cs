using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DietController : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI text;
	private DietEntity _dietEntity;

	public void SetDietEntity(DietEntity dietEntity)
	{
		Debug.Log("SetDietEntity + " + dietEntity.Name);
		_dietEntity = dietEntity;
		text.SetText(dietEntity.Name);
	}

	public void Save()
	{
		PlayerPrefs.SetString(GameConstants.DIET_KEY, _dietEntity.Name);
		FindObjectOfType<DietManager>().CloseContentList();
	}
}
