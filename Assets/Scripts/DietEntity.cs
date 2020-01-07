using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietEntity
{
	private string name;

	public DietEntity(string name)
	{
		this.name = name;
	}

	public string Name => name;
}
