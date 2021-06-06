using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Obstacle : MonoBehaviour ,	IComparable<Obstacle>
{
	public SpriteRenderer M_SpriteRender
	{
		get;
		set;
	}
	private Color Default;
	private Color Faded;
	public int CompareTo(Obstacle other)
	{
		if (M_SpriteRender.sortingOrder > other.M_SpriteRender.sortingOrder)
		{
			return 1;
		}
		else if (M_SpriteRender.sortingOrder < other.M_SpriteRender.sortingOrder)
		{
			return -1;
		}
			return 0;
	}
    // Start is called before the first frame update
    void Start()
    {
		M_SpriteRender = GetComponent<SpriteRenderer>();
		Default = M_SpriteRender.color;
		Faded = Default;
		Faded.a = 0.2f;
    }
	public void FadedOut()
	{
		M_SpriteRender.color = Faded;
	}
	public void FadeIn()
	{
		M_SpriteRender.color = Default;
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
