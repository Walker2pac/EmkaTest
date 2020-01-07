using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DietManager : MonoBehaviour
{
	private List<DietEntity> _allDiet = new List<DietEntity>();
	[SerializeField] private RectTransform _contentList;
	[SerializeField] private TextMeshProUGUI prefsText;
	[SerializeField] private GameObject dietPrefab;

	private void Start()
	{
		CreateAllDiet();
	}

	private void CreateAllDiet()
	{
		for (int i = 0; i < 5; i++)
		{
			_allDiet.Add(new DietEntity(i.ToString()));
		}
	}

	public void CreateAllDietButtons()
	{
		foreach (var dietEntity in _allDiet)
		{
			GameObject dietButton = Instantiate(dietPrefab);
			dietButton.GetComponent<RectTransform>().SetParent(_contentList);
			dietButton.GetComponent<DietController>().SetDietEntity(dietEntity);
		}
	}

	public void CloseContentList()
	{
		_contentList.gameObject.SetActive(false);
	}

	public void ReadPrefs()
	{
		string diet = PlayerPrefs.GetString(GameConstants.DIET_KEY);
		prefsText.SetText(diet);
	}
}
