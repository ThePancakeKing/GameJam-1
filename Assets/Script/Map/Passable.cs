using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passable : MonoBehaviour
{
	private BoxCollider2D mycollider;

	public BoxCollider2D Mycollider { get => mycollider; set => mycollider = value; }

	private void Start()
	{
		Mycollider = GetComponent<BoxCollider2D>();
	}


	public void pass()
	{
		mycollider.enabled = false;
	}
	public void notpass()
	{
		mycollider.enabled = true;
	}
	public void trigger()
	{
		mycollider.isTrigger = true;
	}
	public void nottrigger()
	{
		mycollider.isTrigger = false;
	}
}

